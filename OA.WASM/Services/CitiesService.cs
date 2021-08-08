using OA.Domin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace OA.WASM.Services
{
    public class CitiesService : ServiceBase<City>
    {
        public CitiesService(HttpClient httpClient) : base(httpClient, "Cities")
        {

        }
    }
}
