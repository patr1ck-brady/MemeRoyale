using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MemeRoyale.Models
{
    public class Vote
    {
        public int Id { get; set; }
        public User User { get; set; }
        public Submission Submission { get; set; }
    }
}
