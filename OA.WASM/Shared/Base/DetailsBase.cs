using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;
using OA.Domin.Resources;
using OA.WASM.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OA.WASM.Shared
{
    public class DetailsBase<T> : ComponentBase, IDisposable where T : class, new()
    {
        [Inject]
        public HttpInterceptorService InterceptorService { get; set; }

        [Inject]
        public ServiceBase<T> DetailService { get; set; }


        [Inject]
        public IStringLocalizer<CommonResources> Localizer { get; set; }

        [Inject]
        public IServiceProvider ServiceProvider { get; set; }

        [Parameter]
        public string Id { get; set; }

        public T EntityItem { get; set; } = new T();


        protected async override Task OnInitializedAsync()
        {
            InterceptorService.RegisterEvents();

            int id = Convert.ToInt32(Id);
            EntityItem = await DetailService.Get(id);
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
