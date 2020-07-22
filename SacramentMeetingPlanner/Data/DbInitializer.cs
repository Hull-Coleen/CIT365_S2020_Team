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
            new Hymn{Title="The Morning Breaks",PageNumber=1},
            new Hymn{Title="The Spirit of God",PageNumber=2},
            new Hymn{Title="Nearer, My God, to Thee",PageNumber=100},
            new Hymn{Title="Sabbath Day",PageNumber=148},
            new Hymn{Title="Abide with Me!",PageNumber=166},
            new Hymn{Title="In Humility, Our Savior",PageNumber=172},
            new Hymn{Title="All Creatuers of Our God and King",PageNumber=62},
            new Hymn{Title="With Songs of Praise",PageNumber=71},
            };

            foreach (Hymn h in hymns)
            {
                context.Hymns.Add(h);
            }
            context.SaveChanges();

            if (context.SacramentMeetings.Any())
            {
                return;
            }

            var Meeting = new SacramentMeeting[]
            {
            new SacramentMeeting{SacramentDate = DateTime.Parse("2007-09-01") , Topic="Prayer", ConductingBishopric= "John Smith", OpeningPrayer="Pilar Pedrozo", ClosingPrayer="Pablo Almirante", OpeningHymnId="The Morning Breaks Pg 1", ClosingHymnId="The Spirit of God pg. 2", SacramentHymnId="Nearer, My God, to Thee pg 100", IntermediateHymn="Special Number", Speaker1="", Speaker2="Elena Mendoza",Speaker3="",Speaker4="",Speaker5="",Speaker6="" },
            new SacramentMeeting{SacramentDate = DateTime.Parse("2007-08-01") , Topic="Sabbath Day", ConductingBishopric= "Robert Jones", OpeningPrayer="Sulivan Mendez", ClosingPrayer="Claudia Velasquez", OpeningHymnId="Abide with Me! Pg 166", ClosingHymnId="In Humility, Our Savior pg. 172", SacramentHymnId="Sabbath Day pg 148", IntermediateHymn="", Speaker1="Diego Montenegro", Speaker2="",Speaker3="",Speaker4="",Speaker5="",Speaker6="" },
            new SacramentMeeting{SacramentDate = DateTime.Parse("2007-07-01") , Topic="Faith", ConductingBishopric= "John Smith", OpeningPrayer="Diego Montenegro", ClosingPrayer="Claudia Velasquez", OpeningHymnId="With Songs of Praise Pg 71", ClosingHymnId="The Spirit of God pg. 2", SacramentHymnId="Nearer, My God, to Thee pg 100", IntermediateHymn="Ward Choir", Speaker1="Elena Mendoza", Speaker2="Diego Montenegro",Speaker3="",Speaker4="",Speaker5="",Speaker6="" },
            };

            foreach (SacramentMeeting m in Meeting)
            {
                context.SacramentMeetings.Add(m);
            }
            context.SaveChanges();




        }
        }
    }

