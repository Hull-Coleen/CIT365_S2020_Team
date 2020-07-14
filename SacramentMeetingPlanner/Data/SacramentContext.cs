using Microsoft.EntityFrameworkCore;
using SacramentMeetingPlanner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SacramentMeetingPlanner.Data
{
    public class SacramentContext:DbContext
    {
        public SacramentContext(DbContextOptions<SacramentContext> options) : base(options)
        {

        }

        public DbSet<SacramentMeeting> SacramentM { get; set; }
        public DbSet<Hymn> Hymns { get; set; }
        public DbSet<Member> Members { get; set; }
    }
}
