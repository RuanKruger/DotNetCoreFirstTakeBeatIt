using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DotNetFirstTake.Models;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace DotNetFirstTake
{
    public class Program
    {
        public static void Main(string[] args)
        {
			//BuildWebHost(args).Run();
			var host = BuildWebHost(args);

			using (var scope = host.Services.CreateScope())
			{
				var service = scope.ServiceProvider;
				try
				{
					var context = service.GetRequiredService<AppDbContext>();
					DbInitializer.Seed(context);
				}
				catch (Exception)
				{
					Console.WriteLine("This is the end...");
				}
			}

			host.Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
