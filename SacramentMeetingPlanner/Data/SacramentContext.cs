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

        public DbSet<SacramentMeeting> SacramentMeetings { get; set; }
        public DbSet<Hymn> Hymns { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Speaker> Speakers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SacramentMeeting>().ToTable("SacramentMeeting");
            modelBuilder.Entity<Hymn>().ToTable("Hymn");
            modelBuilder.Entity<Member>().ToTable("Member");
            modelBuilder.Entity<Speaker>().ToTable("Speaker");
            modelBuilder.Entity<Speaker>()
                .HasKey(c => new { c.MeetingID, c.MemberID });
        }
    }
}
