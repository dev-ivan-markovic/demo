using System.Threading.Tasks;
using System.Web.Http;
using Project_Beer.Models;
using Project_Beer.Service;

namespace Project_Beer.WebApi
{
    public class SearchController : ApiController
    {
        private IBeerService _beerService;

        public SearchController(IBeerService beerService)
        {
            _beerService = beerService;
        }

        [HttpGet]
        public async Task<PagedBeers> Search(string q, int currentPage = 1)
        {
            var result = await _beerService.SearchBeer(q, currentPage);
            return result;
        }
    }
}