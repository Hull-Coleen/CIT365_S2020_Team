using SacramentMeetingPlanner.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SacramentMeetingPlanner.Data
{
    public class DbInitializer
    {
        public static void Initialize(SacramentContext context)
        {
            context.Database.EnsureCreated();

            // Look for any member
            if (context.Members.Any())
            {
                return; // Db has been seededx
            }

            var members = new Member[]
            {
            new Member{FirstName="Pilar",LastName="Pedrozo",Calling="Relief Society President",PhoneNumber="625-358-9856"},
            new Member{FirstName="Pablo",LastName="Almirante",Calling="Elders Quorum President",PhoneNumber="625-548-8214"},
            new Member{FirstName="Elena",LastName="Mendoza",Calling="Ward Music Chairman",PhoneNumber="625-254-8963"},
            new Member{FirstName="Sulivan",LastName="Mendez",Calling="Ward Music Director",PhoneNumber="625-578-2354"},
            new Member{FirstName="Claudia",LastName="Velasquez",Calling="Ward Organist or Pianist",PhoneNumber="625-546-2145"},
            new Member{FirstName="Diego",LastName="Montenegro",Calling="Elders Quorum Teacher",PhoneNumber="625-754-7854"},
            new Member{FirstName="Amanda",LastName="Rocoso",Calling="Ward Relief Society Teacher",PhoneNumber="625-658-5698"},
            new Member{FirstName="Robert",LastName="Jones",Calling="Bishopric Counsel",PhoneNumber="111-658-5698"},
            new Member{FirstName="John",LastName="Smith",Calling="Bishop",PhoneNumber="111-222-5698"}
            };

            foreach (Member s in members)
                {
                context.Members.Add(s);
            }
            context.SaveChanges();


            if (context.Hymns.Any())
            {
                return;
            }

            var hymns = new Hymn[]
            {
            new Hymn{Title="Prayer",PageNumber=1},
            new Hymn{Title="Faith",PageNumber=2},
            new Hymn{Title="Sacrament",PageNumber=100},
            new Hymn{Title="Sacrament 2",PageNumber=149},
            new Hymn{Title="Prayer 2",PageNumber=5},
            new Hymn{Title="Prayer 3",PageNumber=6},
            new Hymn{Title="Faith 3",PageNumber=7},
            new Hymn{Title="Faiath 3",PageNumber=8},
            };

            foreach (Hymn h in hymns)
            {
                context.Hymns.Add(h);
            }
            context.SaveChanges();

        }
        }
    }

