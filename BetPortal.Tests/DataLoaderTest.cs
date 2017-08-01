using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BetPortal.Services;
using BetPortal.Entities;
using System.Collections.Generic;

namespace BetPortal.Tests
{
    [TestClass]
    public class DataLoaderTest
    {
        IDataLoader loadService;

        [TestInitialize]
        public void Setup()
        {
            loadService = new DataLoader();
        }

        [TestMethod]
        public void shouldReturnCustomerFromRest()
        {
            List<Customer> customers = loadService.LoadCustomerFromRest();
            Assert.IsTrue(customers.Count > 0);
        }

        [TestMethod]
        public void shouldReturnRaceFromRest()
        {
            List<Race> races = loadService.LoadRacesFromRest();
            Assert.IsTrue(races.Count > 0);
        }

        [TestMethod]
        public void shouldReturnBetFromRest()
        {
            List<Bet> bets = loadService.LoadBetsFromRest();
            Assert.IsTrue(bets.Count > 0);
        }
    }
}
