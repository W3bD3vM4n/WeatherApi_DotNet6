using Microsoft.AspNetCore.Mvc;
using WeatherApi.Services;
using Newtonsoft.Json;
using System.Text.Json.Nodes;
using WeatherApi.Models;
using Microsoft.AspNetCore.Cors;

namespace WeatherApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<TomorrowApiResponseModel>> ObtenerClimaPorLocalizacion(string location)
        {
            WeatherService weatherService = new WeatherService();
            string response = await weatherService.ObtenerClimaPorLocalizacion(location);

            var jsonObject = JsonConvert.DeserializeObject<TomorrowApiResponseModel>(response);
            return jsonObject;
        }
    }
}
