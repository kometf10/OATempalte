using MatBlazor;
using OA.Domin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace OA.WASM.Services
{
    public class WeatherService : ServiceBase<WeatherForecast>
    {
        public WeatherService(HttpClient httpClient) : base(httpClient, nameof(WeatherForecast))
        {            

        }

    }
}
