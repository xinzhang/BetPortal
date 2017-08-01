using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BetPortal.ViewModels
{
    public class BetViewModel
    {
        public int RaceId { get; set; }
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public decimal ReturnStake { get; set; }
        public bool Won { get; set; }
        public string RaceName { get; set; }
        public DateTime RaceStart { get; set; }
    }
}