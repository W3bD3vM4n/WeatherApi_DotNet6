using Microsoft.AspNetCore.Mvc;
using WeatherApi.Services;
using Newtonsoft.Json;
using System.Text.Json.Nodes;
using WeatherApi.Models;

namespace WeatherApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        //[HttpGet]
        //public async Task<ActionResult<WeatherUnlockedApiResponseModel>> ObtenerDatosApiUno()
        //{
        //    WeatherService weatherService = new WeatherService();
        //    string response = await weatherService.ObtenerDatosApiUno();

        //    var jsonObject = JsonConvert.DeserializeObject<WeatherUnlockedApiResponseModel>(response);
        //    return jsonObject;
        //}

        [HttpGet]
        public async Task<ActionResult<TomorrowApiResponseModel>> ObtenerDatosApiDos()
        {
            WeatherService weatherService = new WeatherService();
            string response = await weatherService.ObtenerDatosApiDos();

            var jsonObject = JsonConvert.DeserializeObject<TomorrowApiResponseModel>(response);
            return jsonObject;
        }
    }
}
