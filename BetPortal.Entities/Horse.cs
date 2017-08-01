using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetPortal.Entities
{
    public class Horse
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Odds { get; set; }

    }
}
