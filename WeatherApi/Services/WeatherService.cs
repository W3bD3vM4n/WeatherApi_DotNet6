using System.Net;
using System.IO;
using System.Net.WebSockets;

namespace WeatherApi.Services
{
    public class WeatherService
    {
        public async Task<string> ObtenerDatosApiUno()
        {
            // Create an instance of HttpClient
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    var url1 = "http://api.weatherunlocked.com/api/current/40.71,-74.00?app_id=2bd5d910&app_key=8440260ebc977ce1f193b750dbae9e75";
                    // Send a GET request to the URL
                    HttpResponseMessage response = await client.GetAsync(url1);

                    // Check if the response is successful (status code in the range 200-299)
                    if (response.IsSuccessStatusCode)
                    {
                        // Read the response content as a string
                        string responseBody = await response.Content.ReadAsStringAsync();

                        // Display the response body
                        //Console.WriteLine("Response from server:");
                        //Console.WriteLine(responseBody);
                         return responseBody;
                    }
                    else
                    {
                        //Console.WriteLine($"Failed to get data. Status code: {response.StatusCode}");
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    //Console.WriteLine($"An error occurred: {ex.Message}");
                    return null;
                }
            }
        }

        public async Task<string> ObtenerDatosApiDos()
        {
            // Create an instance of HttpClient
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    var url2 = "https://api.tomorrow.io/v4/weather/forecast?location=42.3478,-71.0466&apikey=DQhwRP1knqrr8tiUSF8b2SgSdeSRE7rw";
                    // Send a GET request to the URL
                    HttpResponseMessage response = await client.GetAsync(url2);

                    // Check if the response is successful (status code in the range 200-299)
                    if (response.IsSuccessStatusCode)
                    {
                        // Read the response content as a string
                        string responseBody = await response.Content.ReadAsStringAsync();

                        // Display the response body
                        //Console.WriteLine("Response from server:");
                        //Console.WriteLine(responseBody);
                        return responseBody;
                    }
                    else
                    {
                        //Console.WriteLine($"Failed to get data. Status code: {response.StatusCode}");
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    //Console.WriteLine($"An error occurred: {ex.Message}");
                    return null;
                }
            }
        }
    }   
}
