using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace APIsAndJSON
{
    public class OpenWeatherMapAPI
    {
        HttpClient client = new HttpClient();

        public string weather()
        {
            var weatherURL = "https://api.openweathermap.org/data/2.5/weather?q=manhattan&appid=77187838ad0f0e09a005330f2ab8a823&units=imperial";
            var weatherGet = client.GetStringAsync(weatherURL).Result;
            var weatherParse = JObject.Parse(weatherGet);

            return weatherParse["main"]["temp"].ToString();
        }
    }
}
