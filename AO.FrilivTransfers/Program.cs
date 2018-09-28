using Autofac;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Nop.Core;
using Nop.Core.Data;
using Nop.Core.Domain.Catalog;
using Nop.Core.Domain.Common;
using Nop.Core.Domain.Security;
using Nop.Core.Domain.Stores;
using Nop.Core.Infrastructure;
using Nop.Data;
using Nop.Services.Catalog;
using Nop.Services.Events;
using Nop.Services.Security;
using System;
using System.ComponentModel;

namespace AO.FrilivTransfers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Important: Dummy call to make the Nop.Web.Framework.dll being loaded into AppDomain
            var test = Nop.Web.Framework.AreaNames.Admin;

            var host = WebHost.CreateDefaultBuilder(args)
            .UseKestrel(options => options.AddServerHeader = false)            
            .UseStartup<Startup>()
            .Build();

            var app = host.Services.GetService<IApp>();
            app.InitiateService();           
        }
    }
}
