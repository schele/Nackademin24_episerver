using Serilog;

namespace nackademin24_episerver
{
    public class Program
    {
        public static IConfiguration Configuration { get; } =
        new ConfigurationBuilder()
        .AddJsonFile("appSettings.json", false, true)
        .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")}.json", true, true)
        .AddJsonFile($"appsettings.{Environment.MachineName}.json", true, true)
        .AddEnvironmentVariables()
        .Build();

        public static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
                .ReadFrom.Configuration(Configuration).WriteTo.Console().CreateLogger();

            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureCmsDefaults()
                .UseSerilog()
                .ConfigureWebHostDefaults(webBuilder => webBuilder.UseStartup<Startup>());
    }
}
