using Microsoft.AspNetCore.Hosting;
using System;
using Tutorial.Services.Products.Core;

namespace Tutorial.Services.Products.Host
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseUrls("http://*:5000")
                .UseStartup<Startup>()
                .Build();

            host.Run();
        }
    }
}
