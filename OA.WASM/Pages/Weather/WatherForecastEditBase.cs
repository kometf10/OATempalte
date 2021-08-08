using ComponentLib;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;
using Microsoft.JSInterop;
using OA.Domain;
using OA.Domin;
using OA.Domin.Resources;
using OA.WASM.Services;
using OA.WASM.Services.Auth;
using OA.WASM.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OA.WASM.Pages.Weather
{
    public class WatherForecastEditBase : EditBase<WeatherForecast>
    {

        [Inject]
        ServiceBase<City> CitiesService { get; set; }

        public Dictionary<string, string> CityItems { get; set; } = new Dictionary<string, string>();


        protected async override Task OnInitializedAsync()
        {            
            await GetCityItems();

            await base.OnInitializedAsync();
        }

        public new async Task HandelSubmit()
        {
            EntityItem.City = null;

            await base.HandelSubmit();
        }

        public async Task GetCityItems()
        {
            var cities = await CitiesService.IndexGet();
            foreach(var city in cities)
                CityItems.Add(city.Id.ToString(), city.Name);
            
        }


    }
}
