using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using OA.WASM.Services;
using OA.Domain;
using OA.WASM.Services.Auth;
using System.Net;
using OA.WASM.Services.JsonConverter;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using Toolbelt.Blazor.Extensions.DependencyInjection;
using System.Globalization;
using System.Threading;
using Microsoft.JSInterop;
using OA.Domin;
using BlazorDownloadFile;
using OA.WASM.Services.Reporting;
using OA.WASM.Services.ErrorHandler.Extention;
using OA.WASM.Services.Administration;
using OA.WASM.Services.Upload;
using OA.WASM.Services.Settings;
using OA.Domin.Settings;
using OA.Domin.Logging;
using System.Runtime.InteropServices.ComTypes;
using OA.WASM.Services.Logging;
using OA.WASM.Services.Notifications;
using OA.WASM.Services.Auditing;
using OA.WASM.Services.Auth.Extention;
using FluentValidation;

namespace OA.WASM
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddScoped(sp => new HttpClient 
                { 
                    BaseAddress = new Uri(builder.Configuration.GetSection("BaseUri").Value) 
                }
                .EnableIntercept(sp)
            );

            builder.Services.AddLocalization();
           
            builder.Services.AddHttpClientInterceptor();
            
            builder.Services.AddSingleton<IJsonConverter, JsonConverter>();

            builder.Services.AddBlazoredLocalStorage();

            builder.Services.AddOptions();

            //builder.Services.AddAuthorizationCore();
            builder.Services.AddPolicyBasedAuthorization();

            builder.Services.AddScoped<AuthenticationStateProvider, LocalAuthenticationStateProvider>();

            builder.Services.AddScoped<LocalAuthenticationStateProvider>();

            builder.Services.AddScoped<IAuthService, AuthService>();

            builder.Services.AddScoped<RefreshTokenService>();

            builder.Services.AddScoped<HttpInterceptorService>();

            builder.Services.AddBlazorDownloadFile(ServiceLifetime.Scoped);
            

            //Services ErrorHandler Extention
            builder.Services.AddStateManagement();

            builder.Services.AddScoped<IAdministrationService, AdministrationService>();
            builder.Services.AddScoped<IReportingService, ReportingService>();
            builder.Services.AddScoped<IUploadService, UploadService>();
            builder.Services.AddScoped<IAppSettingsService, AppSettingsService>();
            builder.Services.AddScoped<INotificationServices, NotificationService>();
            builder.Services.AddScoped<IAuditsService, AuditsService>();
            builder.Services.AddScoped<ServiceBase<ExceptionLog>, ExceptionLogService>();

            //Test
            builder.Services.AddScoped<ServiceBase<WeatherForecast>, WeatherService>();
            builder.Services.AddScoped<ServiceBase<City>, CitiesService>();

           
           

            var host = builder.Build();

            var localStorageService = host.Services.GetRequiredService<ILocalStorageService>();
            var cult = await localStorageService.GetItemAsync<string>("Culture");
            if (!string.IsNullOrEmpty(cult))
            {
                var culture = CultureInfo.CreateSpecificCulture(cult);

                CultureInfo.DefaultThreadCurrentCulture = culture;
                CultureInfo.DefaultThreadCurrentUICulture = culture;

                if(cult == "ar-SY")
                {
                    var Jsrt = host.Services.GetRequiredService<IJSRuntime>();
                    await Jsrt.InvokeVoidAsync("AddClass", "body", "rtl");
                }

                var httpClient = host.Services.GetRequiredService<HttpClient>();
                httpClient.DefaultRequestHeaders.AcceptLanguage.Add(new System.Net.Http.Headers.StringWithQualityHeaderValue(cult));

                //Thread.CurrentThread.CurrentCulture = culture;
                //Thread.CurrentThread.CurrentUICulture = culture;
            }

            await host.RunAsync();
        }

    }
}
