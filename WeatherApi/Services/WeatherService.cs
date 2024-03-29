﻿using System.Net;
using System.IO;
using System.Net.WebSockets;

namespace WeatherApi.Services
{
    public class WeatherService
    {
        public async Task<string> ObtenerClimaPorLocalizacion(string location)
        {
            // Create an instance of HttpClient
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    var urlBase = "https://api.tomorrow.io/v4/weather/forecast?location=";

                    var apiKey = "&apikey=DQhwRP1knqrr8tiUSF8b2SgSdeSRE7rw";

                    var urlCompleted = urlBase + location + apiKey;

                    // Send a GET request to the URL
                    HttpResponseMessage response = await client.GetAsync(urlCompleted);

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
