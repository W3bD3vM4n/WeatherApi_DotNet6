using Newtonsoft.Json;

namespace WeatherApi.Models
{
    public class WeatherUnlockedApiResponseModel
    {
        [JsonProperty("lat")]
        public decimal Latitude { get; set; }

        [JsonProperty("lon")]
        public decimal Longitude { get; set; }
    }
}
