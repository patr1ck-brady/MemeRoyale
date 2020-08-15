using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MemeRoyale.Models
{
    public class Game
    {
        public Game()
        {
            Rounds = new List<Round>();
        }

        public int Id { get; set; }
        public int NumRounds { get; set; }
        public DateTime CreateDate { get; set; }
        public Room Room { get; set; }
        public ICollection<Round> Rounds { get; set; }
    }
}
