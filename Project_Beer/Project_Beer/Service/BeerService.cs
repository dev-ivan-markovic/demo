using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Project_Beer.Models;

namespace Project_Beer.Service
{
    public class BeerService: IBeerService
    {
        private string BaseUri = ConfigurationManager.AppSettings["beerServiceUrl"];

        public async Task<PagedBeers> GetBeersAsync(List<KeyValuePair<string, string>> parameters)
        {
            var result = new PagedBeers();
            var uri = string.Format(BaseUri,"beers") + "&";
            if (parameters != null && parameters.Any())
            {
                foreach (var pair in parameters)
                {
                    uri += string.Format("{0}={1}&", pair.Key, pair.Value);
                }
            }
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    result = await response.Content.ReadAsAsync<PagedBeers>();
                }
                return result;
            }
        }
    }
}