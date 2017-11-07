﻿using System.Threading.Tasks;
using solcast.types;
using ServiceStack;

namespace solcast
{
    public static class Power
    {

        /// <summary>
        /// Solcast Power Forecast for the position
        /// </summary>
        /// <param name="position">Position is a EPSG 4326 Latitude/Longitude position on the Earth</param>
        /// <param name="apiKey">API Key override to use instead of environment variable *SOLCAST_API_KEY*</param>
        /// <returns></returns>        
        public static async Task<GetPvPowerForecastsResponse> Forecast(Location position, string apiKey = null)
        {
            using (var client = new JsonHttpClient(API.Url))
            {
                client.DefaultSolcastClient(API.Key(apiKey));
                var request = position.ToPowerForecasts();             
                var response = await client.GetAsync(request);
                return response;
            }
        }
        /// <summary>
        /// Solcast Power Estimated Actuals for the position
        /// </summary>
        /// <param name="position">Position is a EPSG 4326 Latitude/Longitude position on the Earth</param>
        /// <param name="apiKey">API Key override to use instead of environment variable *SOLCAST_API_KEY*</param>
        /// <returns></returns>         
        public static async Task<GetPvPowerEstimatedActualsResponse> EstimatedActuals(Location position, string apiKey = null)
        {
            using (var client = new JsonHttpClient(API.Url))
            {
                client.DefaultSolcastClient(API.Key(apiKey));
                var request = position.ToPowerEstimatedActuals();                
                var response = await client.GetAsync(request);
                return response;
            }              
        }
        /// <summary>
        /// Solcast Power Latest Estimated Actuals for the position
        /// </summary>
        /// <param name="position">Position is a EPSG 4326 Latitude/Longitude position on the Earth</param>
        /// <param name="apiKey">API Key override to use instead of environment variable *SOLCAST_API_KEY*</param>
        /// <returns></returns>       
        public static async Task<GetPvPowerEstimatedActualsResponse> LatestEstimatedActuals(Location position, string apiKey = null)
        {
            using (var client = new JsonHttpClient(API.Url))
            {
                client.DefaultSolcastClient(API.Key(apiKey));
                var request = position.ToLatestPowerEstimatedActuals();                
                var response = await client.GetAsync(request);
                return response;
            }
        }          
    }
}