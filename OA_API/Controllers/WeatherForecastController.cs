using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using OA.DataAccess;
using OA.Domin;
using OA.Domin.Requests;
using OA.Domin.DataFilter;
using OA.Domin.Paging;
using OA.Domin.RequestFeatures;
using OA.Services.Reporting;
using Microsoft.Extensions.Caching.Memory;
using OA.Services.Caching;

namespace OA_API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherForecastController : BaseController<WeatherForecast>
    {

        //public WeatherForecastController(AppDbContext context, ULMemoryCacheService cache) : base(context, cache)
        //{

        //}

        public WeatherForecastController(AppDbContext context) : base(context)
        {

        }

    }
}
