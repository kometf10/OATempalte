using Microsoft.EntityFrameworkCore.Infrastructure;
using OA.Domin;
using OA.Domin.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;

namespace OA.Domin
{
    public class WeatherForecast : BaseEntity
    {

        public WeatherForecast()
        {

        }
        private ILazyLoader LazyLoader { get; set; }
        public WeatherForecast(ILazyLoader lazyLoader)
        {
            this.LazyLoader = lazyLoader;
        }

        [DisplayName("Date")]
        [Required(ErrorMessage = "Required field")]
        public DateTime Date { get; set; }

        [DisplayName("Temperature C")]
        [Required(ErrorMessage = "Required field")]
        [Range(minimum:0, maximum:100, ErrorMessage = "Field Value Must Be Between 0 and 100")]
        public int TemperatureC { get; set; }

        [DisplayName("Temperature F")]
        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        [DisplayName("Summary")]
        [Required(ErrorMessage = "Required field")]
        [MaxLength(20, ErrorMessage = "Max length is 2 characters")]
        public string Summary { get; set; }

        [PropFlag("FK")]
        [DisplayName("City")]
        //[Required(ErrorMessage = "Required field")]
        public int? CityId { get; set; }

        private City _City;

        [PropFlag("FK_REF")]
        public virtual City City 
        {
            get => LazyLoader.Load(this, ref _City);
             
            set => _City = value;
        }

    }
}
