using Newtonsoft.Json;

namespace WeatherApi.Models
{
    public class Location
    {
        [JsonProperty("lat")]
        public decimal Latitude { get; set; }

        [JsonProperty("lon")]
        public decimal Longitude { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
