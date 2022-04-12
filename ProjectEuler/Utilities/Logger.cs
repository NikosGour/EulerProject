using Serilog;
using Serilog.Sinks.SystemConsole.Themes;

namespace ProjectEuler.Utilities;

public sealed class Logger : IDisposable
{

     // ReSharper disable once RedundantDefaultMemberInitializer
     private static bool _initialized { get; set; } = false;

     public Logger()
     {
          initialize();
     }

     private static void initialize()
     {
          if (_initialized) return;

          Log.Logger = new LoggerConfiguration()
                       .MinimumLevel.Verbose()
                       .WriteTo.Console(
                            outputTemplate: "[{Timestamp:HH:mm:ss} | {Level}] {Message}{NewLine}{Exception}",
                            theme: AnsiConsoleTheme.Sixteen
                            )
                       .CreateLogger();

          _initialized = true;
     }

     public void Dispose()
     {
          Log.CloseAndFlush();
     }
}