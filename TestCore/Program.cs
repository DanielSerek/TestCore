using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestCore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            string environment = "Development";

            return Host.CreateDefaultBuilder(args)
                  
                  .ConfigureWebHostDefaults(webBuilder =>
                  {
                      webBuilder.UseStartup<Startup>()
                      .UseIISIntegration()
                      .UseEnvironment(environment);
                  });
        }
       
                
    }
}
