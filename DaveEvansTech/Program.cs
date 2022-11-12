using Blazored.Toast;
using DaveEvansTech.Contracts;
using DaveEvansTech.Helpers;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Hosting.Internal;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Syncfusion.Blazor;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DaveEvansTech
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            // Syncfusion -- register community service license
            Syncfusion.Licensing.SyncfusionLicenseProvider
                .RegisterLicense(builder.Configuration["SyncfusionLicense"]);

            ConfigureServices(builder.Services);

            await builder.Build().RunAsync();
        }
        private static void ConfigureServices(IServiceCollection services)
        {
            // Syncfusion
            services.AddSyncfusionBlazor();

            //services.AddScoped<IRepository, Repository>();
            services.AddTransient<ConvertHtmlToPdfService>();           
            
            // For all non-identity purposes
            services.AddTransient<IPostmarkEmailSender, EmailSender>();

            services.AddTransient<BlazorTimerService>();

            services.AddScoped<BriefFormService>();

            services.AddScoped<IAppToastService, AppToastService>();

            services.AddScoped<IFileStorageService, AzureStorageService>();

            services.AddBlazoredToast();
        }
    }
}
