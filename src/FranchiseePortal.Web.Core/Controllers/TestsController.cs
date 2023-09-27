using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading;
using System;
using FranchiseePortal.ToursWebApiClient.Api;
using System.Threading.Tasks;

namespace FranchiseePortal.Web.Controllers
{
    [Route("[controller]/[action]")]
    public class TestsController : FranchiseePortalControllerBase
    {
        private ILogger<TestsController> _logger;
        private readonly ITestsApi _toursTestsApiClient;

        public TestsController(
            ILogger<TestsController> logger,
            ITestsApi toursTestsApiClient)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _toursTestsApiClient = toursTestsApiClient;
        }

        /// <summary>
        /// Calls log statements for each log level
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [HttpGet("logging")]
        public IActionResult LoggingAsync(CancellationToken cancellationToken = default)
        {
            _logger.LogTrace("Trace log");
            _logger.LogDebug("Debug log");
            _logger.LogInformation("Information level log");
            _logger.LogWarning("Warning level log");
            _logger.LogError("Error level log");
            _logger.LogCritical("Critical level log");

            return Ok();
        }

        /// <summary>
        /// Throws an unhandled exception
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>

        [HttpGet("unhandled-exceptions")]
        public IActionResult UnhandledExceptionAsync(CancellationToken cancellationToken = default)
        {
            try
            {
                _logger.LogInformation("Throwing an exception");
                throw new Exception("Unhandled exception");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Caught exception, rethrowing");
                throw;
            }
        }

        /// <summary>
        /// Calls Tours API endpoint that will return a 500 error and should throw an unhandled exception
        /// to help with verifying exception instrumentation all the way to dependencies
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [HttpGet("tours-api-error")]
        public async Task<IActionResult> ToursApiErrorAsync(CancellationToken cancellationToken = default)
        {
            try
            {
                _logger.LogInformation("Calling Tours API GET /tests/unhandled-exceptions"); 
                await _toursTestsApiClient.ApiTestsUnhandledExceptionsGetAsync(cancellationToken: cancellationToken);
                return Ok();
            }
            catch(Exception ex)
            {
                _logger.LogError(ex, "Caught exception, rethrowing");
                throw;
            }
        }

        /// <summary>
        /// Calls Tours API endpoint that will generated log statements and returns 200 OK
        /// to help with verifying logging instrumentation all the way to dependencies
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [HttpGet("tours-api-logging")]
        public async Task<IActionResult> ToursApiLoggingAsync(CancellationToken cancellationToken = default)
        {
            try
            {
                _logger.LogInformation("Calling Tours API GET /tests/logging");
                await _toursTestsApiClient.ApiTestsLoggingGetAsync(cancellationToken: cancellationToken);
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Caught exception, rethrowing");
                throw;
            }
        }
    }
}
