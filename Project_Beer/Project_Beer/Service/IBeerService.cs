using System.Collections.Generic;
using System.Threading.Tasks;
using Project_Beer.Models;

namespace Project_Beer.Service
{
    public interface IBeerService
    {
        Task<PagedBeers> GetBeersAsync(List<KeyValuePair<string, string>> parameters);
        Task<PagedBeers> SearchBeer(string s, int currentPage);
    }
}