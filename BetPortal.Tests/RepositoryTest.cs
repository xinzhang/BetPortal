using BetPortal.Entities;
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
    public class RepositoryTest
    {
        BetRespository respository;
        IDataLoader dataLoader;

        [TestInitialize]
        public void Setup()
        {
            this.dataLoader = new DataLoader();
            this.respository = new BetRespository();

            BetRespository.Races = this.dataLoader.LoadRacesFromRest();
        }

        [TestMethod]
        public void shoulddReturnRace()
        {
            Race r = this.respository.GetRaceInformation(1);
            Assert.AreEqual("R1", r.Name);
            Assert.AreEqual(3, r.Horses.Count);
        }

        [TestMethod]
        public void shoulddReturnNull()
        {
            Race r = this.respository.GetRaceInformation(1000);
            Assert.IsNull(r);
        }
    }
}
