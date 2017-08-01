using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetPortal.Entities
{
    public class Race
    {
        public Race()
        {
            this.Horses = new List<Horse>();
        }

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Start { get; set; }

        public IList<Horse> Horses { get; set; }
    }
}
