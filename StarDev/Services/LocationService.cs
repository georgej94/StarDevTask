using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json;
using StarDev.Interfaces;
using StarDev.Models;

namespace StarDev.Services
{
    public class LocationService : ServiceBase, ILocationService
    {
        private const string LocationsUrl = BaseAddress + "/LocationsApi";

        public async Task<List<Location>> GetLocations()
        {
            var uri = new Uri(LocationsUrl);
            
            var response = await Client.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<Location>>(content);
            }

            return null;
        }
    }
}
