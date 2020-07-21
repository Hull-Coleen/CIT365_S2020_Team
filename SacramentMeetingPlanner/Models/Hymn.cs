using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace SacramentMeetingPlanner.Models
{
    public class Hymn
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int PageNumber { get; set; }
        public string FullHymn
        {
            get
            {
                return Title + "  .. Pg.  " + PageNumber;
            }
        }


    }
}
