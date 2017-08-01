using BetPortal.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BetPortal.Services
{
    public class DataLoader : IDataLoader
    {
        string REST_BASE_URL = "https://whatech-customerbets.azurewebsites.net";
        string customerUrl = "/api/GetCustomers?name=xin";
        string raceUrl = "/api/GetRaces?name=xin";
        string betUrl = "api/GetBets?name=xin";

        public List<Customer> LoadCustomerFromRest()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(this.REST_BASE_URL);

            var response = client.GetStringAsync(this.customerUrl).Result;
            return JsonConvert.DeserializeObject<List<Customer>>(response);
        }

        public List<Race> LoadRacesFromRest()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(this.REST_BASE_URL);

            var response = client.GetStringAsync(this.raceUrl).Result;
            return JsonConvert.DeserializeObject<List<Race>>(response);
        }

        public List<Bet> LoadBetsFromRest()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(this.REST_BASE_URL);

            var response = client.GetStringAsync(this.betUrl).Result;
            return JsonConvert.DeserializeObject<List<Bet>>(response);
        }

    }
}
