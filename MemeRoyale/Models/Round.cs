using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MemeRoyale.Models
{
    public class Round
    {
        public Round()
        {
            Votes = new List<Vote>();
        }

        public int Id { get; set; }
        public int Number { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime EndDate { get; set; }
        public string MemeUrl { get; set; }
        public Game Game { get; set; }
        public ICollection<Vote> Votes { get; set; }
    }
}
