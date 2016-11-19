using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project_Beer.Service;

namespace Project_Beer_TEST
{
    [TestClass]
    public class TestBeerService
    {
        private IBeerService _target;

        [TestInitialize]
        public void Init()
        {
            _target = new BeerService();
        }
        [TestMethod]
        public async Task BeerService_Get_FirstPage()
        {
            var result = _target.GetBeersAsync(new List<KeyValuePair<string, string>>());
            await result;
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Result.CurrentPage==1);      
        }
        [TestMethod]
        public async Task BeerService_Get_NonExistingPage()
        {
            var result = _target.GetBeersAsync(new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair<string, string>("p",int.MaxValue.ToString())
            });
            await result;
            Assert.IsNotNull(result);
            Assert.IsNull(result.Result.Data);
        }
    }
}
