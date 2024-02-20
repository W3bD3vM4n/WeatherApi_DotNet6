using Newtonsoft.Json;

namespace WeatherApi.Models
{
    public class TomorrowApiResponseModel
    {
        [JsonProperty("timelines")]
        public Timelines Timelines { get; set; }

        [JsonProperty("location")]
        public Location Location { get; set; }
    }
}
