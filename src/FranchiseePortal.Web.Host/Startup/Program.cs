using FranchiseePortal.Web.Helpers;
using Goddard.AspNetCore.Builder;
using Goddard.AspNetCore.Logging;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace FranchiseePortal.Web.Startup
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Serilog.Debugging.SelfLog.Enable(msg => Console.WriteLine(msg));

            // Initial bootstrap setup for two-stage init
            // before DI and configuration are available
            var logger = GoddardLog.SetupBootstrapLogger();
            CurrentDirectoryHelpers.SetCurrentDirectory();

            try
            {
                CreateWebHostBuilder(args).Build().Run();
            }
            catch (Exception ex)
            {
                logger.Fatal(ex, "Host terminated unexpectedly");
                throw;
            }
            finally
            {
                logger.Information("Application shutdown.");
                GoddardLog.CloseAndFlush();
            }
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args)
        {
            return WebHost.CreateDefaultBuilder(args)
                .AddGoddardLogging()
                // 20230317RBP - User Story 16452: Add centralized logging to Application Insights to Tours API
                // Not adding our own health checks since ASP.NET Zero has it
                //.AddGoddardHealthChecks()
                .UseKestrel(opt =>
                {
                    opt.AddServerHeader = false;
                    opt.Limits.MaxRequestLineSize = 16 * 1024;
                })
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIIS()
                .UseIISIntegration()
                .UseStartup<Startup>();
        }
    }
}
