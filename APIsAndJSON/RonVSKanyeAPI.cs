using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace APIsAndJSON
{
    public class RonVSKanyeAPI
    {
        HttpClient client = new HttpClient();
        public string RonSwanson()
        {
            
            var ronSan = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
            var ronSpeaks = client.GetStringAsync(ronSan).Result;
            var ronParse = JArray.Parse(ronSpeaks);
            
            return ronParse[0].ToString();
        }

        public string KanYe()
        {
            var kanyeWest = "https://api.kanye.rest/";
            var kanyeSpeaks = client.GetStringAsync(kanyeWest).Result;
            var kanyeParse = JObject.Parse(kanyeSpeaks);

            return kanyeParse["quote"].ToString();
        }
    }
}
    