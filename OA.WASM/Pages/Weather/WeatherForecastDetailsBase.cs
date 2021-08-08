using Microsoft.AspNetCore.Components;
using OA.Domin;
using OA.WASM.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OA.WASM.Pages.Weather
{
    public class WeatherForecastDetailsBase : ComponentBase
    {
        [Inject]
        public ServiceBase<WeatherForecast> WeatherService { get; set; }

        [Parameter]
        public string Id { get; set; }

        public WeatherForecast WeatherForecastDetails { get; set; }

        protected async override Task OnInitializedAsync()
        {
            int id = Convert.ToInt32(Id);
            WeatherForecastDetails = await WeatherService.Get(id);
            //return base.OnInitializedAsync();
        }

    }
}
