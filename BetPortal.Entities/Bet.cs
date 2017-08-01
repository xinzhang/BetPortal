using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetPortal.Entities
{
    public class Bet
    {
        [Key]
        public int Id { get; set; }

        public decimal ReturnStake { get; set; }
        public bool Won { get; set; }

        public int CustomerId { get; set; }
        public int HorseId { get; set; }
        public int RaceId { get; set; }

        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }

        [ForeignKey("HorseId")]
        public Horse Horse { get; set; }

        [ForeignKey("RaceId")]
        public Race Race { get; set; }

    }
}
