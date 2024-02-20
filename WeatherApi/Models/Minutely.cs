using Newtonsoft.Json;

namespace WeatherApi.Models
{
    public class Minutely
    {
        [JsonProperty("time")]
        public DateTime Time { get; set; }

        [JsonProperty("values")]
        public Values Values { get; set; }
    }
}
