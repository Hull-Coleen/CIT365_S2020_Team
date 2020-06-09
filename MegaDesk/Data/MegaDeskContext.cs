using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MegaDesk.Models
{
    public class MegaDeskContext : DbContext
    {
        public MegaDeskContext (DbContextOptions<MegaDeskContext> options)
            : base(options)
        {
        }

        public DbSet<MegaDesk.Models.DeskQuote> DeskQuote { get; set; }
    }
}
