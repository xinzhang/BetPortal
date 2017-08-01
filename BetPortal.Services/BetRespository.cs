using BetPortal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetPortal.Services
{
    public class BetRespository
    {
        public static List<Customer> Customers;
        public static List<Race> Races;
        public static List<Bet> Bets;

        public Race GetRaceInformation(int raceId)
        {
            return BetRespository.Races.FirstOrDefault(x => x.Id == id);
        }

    }
}
