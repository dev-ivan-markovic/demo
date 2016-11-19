using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project_Beer.Models;
using Project_Beer.Service;
using Project_Beer.WebApi;
using Rhino.Mocks;

namespace Project_Beer_TEST
{
    [TestClass]
    public class TestSearchController
    {
        private SearchController _target;
        private IBeerService _beerServiceStub;

        [TestInitialize]
        public void Init()
        {
            _beerServiceStub = MockRepository.GenerateStub<IBeerService>();
            _target = new SearchController(_beerServiceStub);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public async Task SearchController_Search_WitoutParameter()
        {
            var searchResult = _target.Search(null);
            await searchResult;
        }
        [TestMethod]
        public async Task SearchController_Search_SingleResult()
        {
            var taskMockResult = new Task<PagedBeers>(() => new PagedBeers { CurrentPage = 1, Data = new List<Beer> { new Beer() } });
            _beerServiceStub.Stub(x => x.SearchBeer(Arg<string>.Is.Anything, Arg<int>.Is.Anything)).Return(taskMockResult);
           var fromResult = _target.Search("");
           taskMockResult.Start();
            await fromResult;
        }

    }
}
