using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherAPI
{
    public class WeatherFor4Days
    {
        public string cod { get; set; }
        public int message { get; set; }
        public int cnt { get; set; }
        public List[] list { get; set; }
        public City city { get; set; }
    }

    public class City
    {
        public int id { get; set; }
        public string name { get; set; }
        public Coord1 coord { get; set; }
        public string country { get; set; }
        public int population { get; set; }
        public int timezone { get; set; }
        public int sunrise { get; set; }
        public int sunset { get; set; }
    }

    public class Coord1
    {
        public float lat { get; set; }
        public float lon { get; set; }
    }

    public class List
    {
        public int dt { get; set; }
        public Main1 main { get; set; }
        public Weather1[] weather { get; set; }
        public Clouds1 clouds { get; set; }
        public Wind1 wind { get; set; }
        public int visibility { get; set; }
        public float pop { get; set; }
        public Sys1 sys { get; set; }
        public string dt_txt { get; set; }
        public Snow snow { get; set; }
    }

    public class Main1
    {
        public float temp { get; set; }
        public float feels_like { get; set; }
        public float temp_min { get; set; }
        public float temp_max { get; set; }
        public int pressure { get; set; }
        public int sea_level { get; set; }
        public int grnd_level { get; set; }
        public int humidity { get; set; }
        public float temp_kf { get; set; }
    }

    public class Clouds1
    {
        public int all { get; set; }
    }

    public class Wind1
    {
        public float speed { get; set; }
        public int deg { get; set; }
        public float gust { get; set; }
    }

    public class Sys1
    {
        public string pod { get; set; }
    }

    public class Snow
    {
        public float _3h { get; set; }
    }

    public class Weather1
    {
        public int id { get; set; }
        public string main { get; set; }
        public string description { get; set; }
        public string icon { get; set; }
    }

}
