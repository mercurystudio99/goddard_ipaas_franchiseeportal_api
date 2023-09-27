using Goddard.AspNetCore.HttpLogging.Details;
using Goddard.Logging;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.IO;
using Serilog;
using System;
using System.IO;
using System.Threading.Tasks;

namespace Goddard.AspNetCore.Logging.HttpLogging
{
    /// <summary>
    /// Middleware to log details
    /// </summary>
    /// <remarks>
    /// credit: https://github.com/serilog/serilog-aspnetcore/issues/168
    /// credit: https://stackoverflow.com/a/43404745/541456
    /// credit: https://elanderson.net/2019/12/log-requests-and-responses-in-asp-net-core-3/
    /// </remarks>
    public class HttpLoggingDetailsMiddleware
    {
        /// <remarks>
        /// The instance should live as long as the process is alive, i.e., for the lifetime of the process.
        /// </remarks>
        private RecyclableMemoryStreamManager _recyclableMemoryStreamManager;
        
        private readonly RequestDelegate _next;
        private readonly IDiagnosticContext diagnosticContext;
        private readonly ILogger<HttpLoggingDetails> _detailsLogger;
        private readonly GoddardHttpLoggingOptions _options;

        public HttpLoggingDetailsMiddleware(
            RequestDelegate next, 
            IDiagnosticContext diagnosticContext, 
            ILogger<HttpLoggingDetails> logger,
            IOptions<GoddardHttpLoggingOptions> options)
        {
            _next = next;
            this.diagnosticContext = diagnosticContext;
            _detailsLogger = logger;
            _options = options.Value;

            _recyclableMemoryStreamManager = new RecyclableMemoryStreamManager();
        }

        public async Task InvokeAsync(HttpContext context)
        {
            // Allow reading multiple times
            context.Request.EnableBuffering();

            // Replace response body stream with our own
            // so we can rewind to beginning and add to log context if needed
            var originalResponseBody = context.Response.Body;
            //using(var responseBody = new MemoryStream())
            using (var responseBody = _recyclableMemoryStreamManager.GetStream())
            {
                context.Response.Body = responseBody;

                try
                {
                    // Call next middleware
                    await _next(context);
                    await EnrichDetailsAsync(context);
                }
                catch (Exception ex)
                {
                    await EnrichDetailsAsync(context, ex);
                    throw;
                }
                finally
                {
                    responseBody.Position = 0;
                    await responseBody.CopyToAsync(originalResponseBody);
                    context.Response.Body = originalResponseBody;
                }
            }           
        }

        private async Task EnrichDetailsAsync(HttpContext context, Exception? ex = null)
        {
            var logLevel = SerilogLogHelper.GetLevel(context, default(double), ex);

            if (!_detailsLogger.IsEnabled(logLevel.ToLogLevel()))
            {
                return;
            }

            diagnosticContext.Set("RequestHeaders", context.Request.Headers);
            diagnosticContext.Set("ResponseHeaders", context.Response.Headers);

            await EnrichRequestBodyAsync(context);
            await EnrichResponseBodyAsync(context);
        }

        private async Task EnrichRequestBodyAsync(HttpContext context)
        {
            // Read and log request body data
            await using var requestStream = _recyclableMemoryStreamManager.GetStream();
            var oldPosition = context.Request.Body.Position;
            context.Request.Body.Position = 0;
            await context.Request.Body.CopyToAsync(requestStream);
            context.Request.Body.Position = oldPosition;
            var body = await ReadStreamInBlocksAsync(requestStream, maxReadLength: _options.BodyLogLimit);
            diagnosticContext.Set("RequestBody", body);
        }

        private async Task EnrichResponseBodyAsync(HttpContext context)
        {
            var stream = context.Response.Body;
            var oldPosition = stream.Position;
            
            // Set stream pointer position to 0 before reading
            stream.Position = 0;

            // Read the body from the stream
            var body = await ReadStreamInBlocksAsync(stream, maxReadLength: _options.BodyLogLimit);

            // Reset the position after reading
            stream.Position = oldPosition;

            diagnosticContext.Set("ResponseBody", body);
        }

        private static async Task<string> ReadStreamInBlocksAsync(
            Stream stream, 
            int count = 4096,
            int maxReadLength = int.MaxValue)
        {
            stream.Seek(0, SeekOrigin.Begin);
            
            using var textWriter = new StringWriter();

            // Do not want to use using because we don't want to close 
            // our underlying stream
            var reader = new StreamReader(stream);
            
            var readBlockBuffer = new char[count];
            int readBlockLength;
            int readLength = 0;

            do
            {
                var countToRead = Math.Min(count, maxReadLength - readLength);

                readBlockLength = await reader.ReadBlockAsync(
                    readBlockBuffer,
                    0,
                    countToRead);
                
                textWriter.Write(readBlockBuffer, 0, readBlockLength);
                
                readLength += readBlockLength;

            } while (readBlockLength > 0 && readLength < maxReadLength);

            return textWriter.ToString();
        }
    }
}
