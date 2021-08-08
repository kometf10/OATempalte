using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;
using OA.Domain;
using OA.Domin;
using OA.Domin.Resources;
using OA.WASM.Services;
using OA.WASM.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OA.WASM.Pages.Weather
{
    public class WatherForecastCreateBase : CreateBase<WeatherForecast>
    {

        [Inject]
        ServiceBase<City> CityService { get; set; }

        public Dictionary<string, string> CityItems { get; set; } = new Dictionary<string, string>();

        protected async override Task OnInitializedAsync()
        {
            await GetCityItems();

        }

        private async Task GetCityItems()
        {
            var cities = await CityService.IndexGet();

            foreach (var city in cities)
                CityItems.Add(city.Id.ToString(), city.Name);

        }


    }
}
