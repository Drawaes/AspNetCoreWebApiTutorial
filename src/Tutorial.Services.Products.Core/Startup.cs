using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using CondenserDotNet.Client;

namespace Tutorial.Services.Products.Core
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddConsulServices();
        }

        public void Configure(IApplicationBuilder app, ILoggerFactory logger, IServiceManager serviceManager)
        {
            logger.AddConsole();

            app.UseMvc();

            serviceManager.AddHttpHealthCheck("api/health", 10)
                .RegisterServiceAsync();
        }
    }
}
