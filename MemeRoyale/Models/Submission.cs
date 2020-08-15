using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MemeRoyale.Models
{
    public class Submission
    {
        public int Id { get; set; }
        public string Caption { get; set; }
        public DateTime CreateDate { get; set; }
        public User User { get; set; }
        public Round Round { get; set; }
    }
}
