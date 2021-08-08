using OA.Domin;
using OA.WASM.Services;
using OA.WASM.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OA.WASM.Pages
{
    public class WatherForcastListBase : ListBase<WeatherForecast>
    {

        public async Task GetIndexDataEvent(string indexName)
        {
            var indexData = new List<IndexData>();
            if (indexName == "City")
            {
                indexData = await GetIndexData<City>();
                //foreach(var item in data)
                //    indexData.Add(new IndexData() { Id = item.Id, Name = item.Name});
            }

            GridFilterRef.IndexDatas = indexData;
        }



    }
}
