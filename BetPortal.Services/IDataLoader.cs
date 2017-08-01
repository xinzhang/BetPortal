using System.Collections.Generic;
using BetPortal.Entities;

namespace BetPortal.Services
{
    public interface IDataLoader
    {
        List<Bet> LoadBetsFromRest();
        List<Customer> LoadCustomerFromRest();
        List<Race> LoadRacesFromRest();
    }
}