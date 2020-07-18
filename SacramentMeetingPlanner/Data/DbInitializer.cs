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
            new Hymn{Title="Come, Listen to a Prophet's Voice",PageNumber=21},
            new Hymn{Title="Joseph Smith's First Prayer",PageNumber=26},
            new Hymn{Title="Praise to the Man",PageNumber=27},
            new Hymn{Title="A Poor Wayfaring Man of Grief",PageNumber=29},
            new Hymn{Title="Come, Come, Ye Saints",PageNumber=30},
            new Hymn{Title="Battle Hymn of the Republic",PageNumber=60},
            new Hymn{Title="Press Forward, Saints",PageNumber=81},
            new Hymn{Title="How Firm a Foundation",PageNumber=85}
            };

            foreach (Hymn h in hymns)
            {
                context.Hymns.Add(h);
            }
            context.SaveChanges();

        }
        }
    }

