using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using DbManager;
using WebSklad.Models;
using System.Threading;

namespace WebSklad
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateWebHostBuilder(args).Build();

            Task.Factory.StartNew(CheckWorkers);

            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var logger = services.GetRequiredService<ILogger<Program>>();
                try
                {
                    var context = services.GetRequiredService<StoreContext>();
                   SampleData.Initialize(context);
                }
                catch (Exception ex)
                {
                   
                    logger.LogError(ex, "An error occurred while seeding the database.");
                }
                
            }
            host.Run();
            
        }

        static void CheckWorkers()
        {
            StoreContext context = new StoreContext();
            WorkerManager manager = new WorkerManager(context);
            
            while (true)
            {
                if (DateTime.Now.Hour == 6 || DateTime.Now.Hour == 19)
                {
                     manager.CheckWorkers();
                }
                Thread.Sleep(3600000);
            }
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
        WebHost.CreateDefaultBuilder(args)
            .UseStartup<Startup>();

       
    }

    
}
