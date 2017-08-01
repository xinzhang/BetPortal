using BetPortal.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetPortal.Tests
{
    [TestClass]
    public class BetPortalServiceTest
    {
        BetPortalService service;
        BetRespository repository;
        IDataLoader dataLoader;

        [TestInitialize]
        public void Setup()
        {
            dataLoader = new DataLoader();
            repository = new BetRespository();
            service = new BetPortalService(repository);

            BetRespository.Bets = dataLoader.LoadBetsFromRest();
            BetRespository.Customers = dataLoader.LoadCustomerFromRest();
            BetRespository.Races = dataLoader.LoadRacesFromRest();
        }

        [TestMethod]
        public void TestGetCustomerBets()
        {
            var result = service.GetCustomerBets();
            Assert.AreEqual(6, result.Count);

            //test it is customer 1
            Assert.AreEqual(1, result[0].CustomerId);
            Assert.AreEqual(4, result[0].Bets.Count);

            //test it is customer 2
            Assert.AreEqual(2, result[1].CustomerId);
            Assert.AreEqual(4, result[1].Bets.Count);

            //test it is customer 3
            Assert.AreEqual(3, result[2].CustomerId);
            Assert.AreEqual(3, result[2].Bets.Count);

            //test customer 6 has no bets and returned
            Assert.AreEqual(6, result[5].CustomerId);
            Assert.AreEqual(0, result[5].Bets.Count);

        }
    }
}
