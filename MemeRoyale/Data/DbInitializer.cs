using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MemeRoyale.Data
{
    public class DbInitializer
    {
        private readonly MemeRoyaleContext _context;

        public DbInitializer(MemeRoyaleContext context)
        {
            _context = context;
        }

        public void InitializeDevelopment()
        {
            _context.Database.Migrate();
        }

        public void InitializeStagingAndProduction()
        {
            _context.Database.Migrate();
        }
    }
}
