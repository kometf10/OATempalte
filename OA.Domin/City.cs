using Microsoft.EntityFrameworkCore.Infrastructure;
using OA.Domain;
using OA.Domin.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OA.Domin
{
    public class City : BaseEntity
    {
        public City()
        {
        }

        private ILazyLoader LazyLoader { get; set; }
        public City(ILazyLoader lazyLoader)
        {
            this.LazyLoader = lazyLoader;
        }

        [DisplayName("City")]
        [Required( ErrorMessage = "Required field")]
        public string Name { get; set; }

        private ICollection<WeatherForecast> _WeatherForecasts;

        [PropFlag("FK_REF")]
        [PropFlag("FK_REF_COLL")]
        public virtual ICollection<WeatherForecast> WeatherForecasts { 
            get => LazyLoader.Load(this, ref _WeatherForecasts); 
            set => _WeatherForecasts = value; 
        }

    }
}
