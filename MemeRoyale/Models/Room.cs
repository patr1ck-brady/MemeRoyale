using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MemeRoyale.Models
{
    public class Room
    {
        public Room()
        {
            Users = new List<User>();
            Games = new List<Game>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Key { get; set; }
        public DateTime CreateDate { get; set; }
        public User CreatedBy { get; set; }
        public ICollection<User> Users { get; set; }
        public ICollection<Game> Games { get; set; }
    }
}
