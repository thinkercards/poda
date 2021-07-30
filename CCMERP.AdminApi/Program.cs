using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CCMERP.AdminApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //for testing
            var a=10;
            // testing
            

            
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)


            //var
                .ConfigureWebHostDefaults(webBuilder =>
                {


                    webBuilder.UseStartup<Startup>();


                });
    }
}
