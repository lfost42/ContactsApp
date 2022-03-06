using Guestbook.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Guestbook
{
    public class Program
    {

        //default setting
        //public static void Main(string[] args)
        //{
        //    CreateHostBuilder(args).Build().Run();
        //}

        //heroku builder
        public static async Task Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();

            var dbContext = host.Services
                                .CreateScope().ServiceProvider
                                .GetRequiredService<ApplicationDbContext>();

            await dbContext.Database.MigrateAsync();

            host.Run();
        }
        //end heroku

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
