using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HttpDemoClientApp.Models
{


    public class WeatherForecastModel
    {
        public DayForecastModel[] Consolidated_weather { get; set; }
        
        public DateTime sun_rise { get; set; }
        public DateTime sun_set { get; set; }
         
        public string Title { get; set; }
       
        public int woeid { get; set; }
     
        public string Timezone { get; set; }
    }

    

}
