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
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Key { get; set; }
        public DateTime CreateDate { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
