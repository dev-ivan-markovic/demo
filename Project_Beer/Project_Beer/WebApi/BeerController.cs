using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using Project_Beer.Models;
using Project_Beer.Service;

namespace Project_Beer.WebApi
{
    public class BeerController : ApiController
    {
        private IBeerService _beerService;

        public BeerController(IBeerService beerService)
        {
            _beerService = beerService;
        }

        [HttpGet]
        public async Task<PagedBeers> GetAllAsync(string order="name", string sort="ASC", int currentPage = 1)
        {
            var result = await _beerService.GetBeersAsync(new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair<string, string>("p",currentPage.ToString()),
                new KeyValuePair<string, string>("order",order),
                new KeyValuePair<string, string>("sort",sort)
            });
            return result;
        }  
    }
}
