using Newtonsoft.Json;

namespace WeatherApi.Models
{
    public class Timelines
    {
        [JsonProperty("minutely")]
        public List<Minutely> Minutely { get; set; }
    }
}
