using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetPortal.Services
{
    public class BetPortalService
    {
        BetRespository repository
        public BetPortalService(BetRespository r) { this.repository = r }

        public Customer GetCustomerBets()
        {
            var qry = from c in BetRespository.Customers
                      join b in BetRespository.Bets on c.Id equals b.CustomerId
                      select new
                      {

                      }
        }
    }
}
