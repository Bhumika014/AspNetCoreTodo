using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace AspNetCoreTodo
{
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    public class Program
    {
        private static object SeedData;

        public static void Main(string[] args)
        {
            var host = BuildWebHost(args);
            NewMethod2(host).Run();

            static object NewMethod2(object host)
            {
                return NewMethod1(host);
            }
        }
        private static void InitializeDatabase(IWebHost host)
{
                 using (var scope = host.Services.CreateScope())
    {
        var services = scope.ServiceProvider;

        try
        {
            SeedData.InitializeAsync(services).Wait();
        }
        catch (Exception ex)
        {
            var logger = services
                .GetRequiredService<ILogger<Program>>();
            logger.LogError(ex, "Error occurred seeding the DB.");
        }
    }
}

        private static object NewMethod1(object host)
        {
            return GetHost(host);
        }

        private static object GetHost(object host)
        {
            return host;
        }

        private static object BuildWebHost(string[] args)
        {
            throw new NotImplementedException();
        }

        private static void NewMethod(string[] args)
        {
            CreateHostBuilder(args).Build().Run();

        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
    
}