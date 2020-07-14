using SacramentMeetingPlanner.Models;
using System;
using System.Collections.Generic;
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
                return; // Db has been seeded
            }

            var members = new Member[]
            {
            new Member{FirstName="Pilar",LastName="Pedrozo",Calling="Relief Society President"},
            new Member{FirstName="Pablo",LastName="Almirante",Calling="Elders Quorum President"},
            new Member{FirstName="Lazaro",LastName="Valdez",Calling="Bishop"},
            new Member{FirstName="Elena",LastName="Mendoza",Calling="Ward Music Chairman"},
            new Member{FirstName="Sulivan",LastName="Mendez",Calling="Ward Music Director"},
            new Member{FirstName="Claudia",LastName="Velasquez",Calling="Ward Organist or Pianist"},
            new Member{FirstName="Diego",LastName="Montenegro",Calling="Elders Quorum Teacher"},
            new Member{FirstName="Amanda",LastName="Rocoso",Calling="Ward Relief Society Teacher"},
            };

            foreach (Member s in members)
                {
                context.Members.Add(s);
            }
            context.SaveChanges();

            

        }
        }
    }

