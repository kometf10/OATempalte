using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;
using Microsoft.JSInterop;
using OA.Domin.Resources;
using OA.WASM.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OA.WASM.Shared
{
    public class CreateBase<T> : ComponentBase, IDisposable where T : class, new()
    {
        [Inject]
        public HttpInterceptorService InterceptorService { get; set; }

        [Inject]
        public IStringLocalizer<CommonResources> Localizer { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        [Inject]
        public ServiceBase<T> CreateService { get; set; }

        [Inject]
        public IJSRuntime JSRT { get; set; }

        [Inject]
        public IServiceProvider ServiceProvider { get; set; }

        public T EntityItem { get; set; } = new T();

        public bool CreateBusy { get; set; } = false;

        protected override void OnInitialized()
        {
            InterceptorService.RegisterEvents();
        }

        public async Task HandelSubmit()
        {
            if (CreateBusy) return;

            CreateBusy = true;
            
            await CreateService.Create(EntityItem);
           
            CreateBusy = false;
            await JSRT.InvokeVoidAsync("Toast", Localizer["Changes Saved Successfully"].Value);
        }

        public async Task<Dictionary<string, string>> GetIndexData<T>()
        {
            var service = (ServiceBase<T>)ServiceProvider.GetService(typeof(ServiceBase<T>));
            var list = await service.IndexGet();

            var dic = new Dictionary<string, string>();
            list.ForEach(i => dic.Add($"{i.Id}", $"{i.Name}"));

            return dic;
        }

        public void Dispose()
        {
            InterceptorService.DisposeEvents();
        }

    }
}
