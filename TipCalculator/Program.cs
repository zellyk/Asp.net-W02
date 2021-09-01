using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System.Globalization;

namespace FutureValue
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
