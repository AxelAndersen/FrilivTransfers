using Autofac;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Nop.Services.Catalog;
using System;
using System.Collections.Generic;
using System.Text;

namespace AO.FrilivTransfers
{
    public static class EngineContextInitializer
    {
        public static void Run(string[] args)
        {
            //var args = new string[] { };
            var host = WebHost.CreateDefaultBuilder(args)
            .UseKestrel(options => options.AddServerHeader = false)
            .UseStartup<Startup>()
            .Build();
            
            //IServiceProvider serviceProvider = host.Services;
            //var bar = serviceProvider.GetService<IProductService>();


            //IProductService service = (IProductService)serviceProvider.GetService(typeof(ProductService));

            Console.Read();
        }
    }
}
