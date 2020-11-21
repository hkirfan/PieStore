﻿using BethanysPieShop.Models;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace BethanyPieShop
{
    public class Program
    {
        public static void Main(string[] args)
        {
//            CreateWebHostBuilder(args).Build().Run();
              var host = CreateWebHostBuilder(args).Build();
              using (var scope = host.Services.CreateScope())
              {
                  var services = scope.ServiceProvider;
                  try
                  {
                      var context = services.GetRequiredService<AppDbContext>();
                      context.Database.Migrate();
                      DbInitializer.Seed(context);
                  }
                  catch
                  {
                      //do nothing
                  }
              }

              host.Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
