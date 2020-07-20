using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SacramentMeetingPlanner.Models
{
    public class Speaker
    {
            public int MemberID { get; set; }
            public int MeetingID { get; set; }
            public Member Member { get; set; }
            public SacramentMeeting SacramentMeeting { get; set; }

    }
}
