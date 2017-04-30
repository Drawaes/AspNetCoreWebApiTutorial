using Microsoft.AspNetCore.Hosting;
using System;
using Tutorial.Services.Inventory.Core;

namespace Tutorial.Services.Inventory.Host
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseUrls("http://localhost:5000")
                .UseStartup<Startup>()
                .Build();

            host.Run();
        }
    }
}
