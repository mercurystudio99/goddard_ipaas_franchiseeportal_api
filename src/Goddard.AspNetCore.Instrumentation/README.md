# Goddard.AspNetCore.Instrumentation

## Configuration

Use following boilerplate in `Program.cs` to add logging and health checks

```
// Initial bootstrap setup for two-stage init
// before DI and configuration are available
var logger = GoddardLog.SetupBootstrapLogger();

try
{
    var builder = WebApplication.CreateBuilder(args);

    // Adds logging
    builder.AddGoddardLogging();

    // Adds health checks
    builder.AddGoddardHealthChecks()

        // Adds DbContext health check
        .AddDbContextCheck<TourContext>();

    ...

    var app = builder?.Build();

    // Add request logging.  This needs to happen early only
    // so everything can be logged
    app!.UseGoddardHttpLogging();

    ...
    
    // Add health checks
    app.MapGoddardHealthChecks();
}
catch
{
    logger.Fatal(ex, "Host terminated unexpectedly");
    throw;
}
finally
{
    GoddardLog.CloseAndFlush();
}
```

### Configuration in appsettings.json
Following sections can drive configuration with `appsettings.json`

```
  "Goddard": {
    "Diagnostics": {
      "HealthCheck": {
        // Path to health check endpoint
        // Defaults to "/health" if not specified
        "Path": "/health"
      }
    },
    "Logging": {
      "HttpLogging": {
        // Max size of body to log
        // Default is 32,768 bytes if not specified
        "BodyLogLimit": 32768
      }
    }
  },
"Serilog": {
    "MinimumLevel": {
      "Default": "Information",
      "Override": {
        // Logging category to include request/response header/body details in request logging.
        // This is separate from the "Serilog.AspNetCore.RequestLoggingMiddleware" request logging category
        // so that we can log add'l details only for warning/error conditions
        "Goddard.AspNetCore.HttpLogging.Details": "Warning",
        // Logging category for request logging.  Levels will log based on requests as follows:
        // Verbose:     All response codes including health checks
        // Information: All response codes not including health checks
        // Warning:     >= 400 response code
        // Error:       >= 500 response codes
        "Serilog.AspNetCore.RequestLoggingMiddleware": "Information"
      }
    },
  "ApplicationInsights": {
    "ConnectionString": "..."
  }    
```

