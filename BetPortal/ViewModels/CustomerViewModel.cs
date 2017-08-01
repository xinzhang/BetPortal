using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BetPortal.ViewModels
{
    public class CustomerViewModel
    {
        public CustomerViewModel()
        {
            this.Bets = new List<BetViewModel>();
        }

        public int CustomerId { get; set; }
        public string Customer { get; set; }
        public decimal TotalStake { get; set; }
        public List<BetViewModel> Bets { get; set; }
    }
}