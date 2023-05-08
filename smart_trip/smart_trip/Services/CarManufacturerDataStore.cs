using smart_trip.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace smart_trip.Services
{
    public class CarManufacturerDataStore : IDataStore<CarManufacturer>
    {
        private HttpClient _httpClient;

        public CarManufacturerDataStore()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(
                     DependencyService.Get<ConfigurationService>().Configuration["ApiUrl"]
                );
        }
        public Task<bool> AddItemAsync(CarManufacturer item)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteItemAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<CarManufacturer> GetItemAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CarManufacturer>> GetItemsAsync(bool forceRefresh = false)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateItemAsync(CarManufacturer item)
        {
            throw new NotImplementedException();
        }
    }
}
