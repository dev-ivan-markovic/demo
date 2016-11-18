using System.Collections.Generic;

namespace Project_Beer.Models
{
    public class PagedBeers
    {
        public int  CurrentPage { get; set; }
        public int NumberOfPages { get; set; }
        public int TotalResults { get; set; }
        public List<Beer> Data { get; set; }
    }
}