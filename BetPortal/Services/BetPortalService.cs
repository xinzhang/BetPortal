using BetPortal.Entities;
using BetPortal.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetPortal.Services
{
    public class BetPortalService
    {
        BetRespository repository;
        public BetPortalService(BetRespository r) { this.repository = r; }

        public List<CustomerViewModel> GetCustomerBets()
        {
            List<CustomerViewModel> customers = new List<CustomerViewModel>();
            var qry = from b in BetRespository.Bets 
                        join r in BetRespository.Races on b.RaceId equals r.Id
                        join c in BetRespository.Customers on b.CustomerId equals c.Id
                      select new BetViewModel
                      {
                          ReturnStake = b.ReturnStake,
                          Won = b.Won,
                          CustomerId = c.Id,
                          CustomerName = c.Name,
                          RaceName = r.Name,
                          RaceId = r.Id,
                          RaceStart = r.Start
                      };

            var dict = qry.ToList().GroupBy(x => x.CustomerId)
                .ToDictionary(grp => grp.Key, grp => grp.Select(x => x).ToList());

            //as this is to get all customers so we need to 
            //return all customers even there is no bets for the customer

            BetRespository.Customers.OrderBy(x=>x.Id).ToList().ForEach(x =>
            {
                var vm = new CustomerViewModel()
                {
                    CustomerId = x.Id,
                    Customer = x.Name,                    
                };

                if (dict.ContainsKey(x.Id))
                {
                    vm.Bets = dict[x.Id];
                    //calculate the total stake in server side
                    vm.TotalStake = vm.Bets.Sum(item => item.ReturnStake);
                }

                customers.Add(vm);
        }); 

            return customers;
        }


    }
}
