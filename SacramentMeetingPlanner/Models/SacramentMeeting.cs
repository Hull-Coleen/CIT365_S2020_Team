using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SacramentMeetingPlanner.Models
{
    public class SacramentMeeting
    {
        public int ID { get; set; }
        [Required]        
        [DataType(DataType.Date)]        
        [Display(Name = "Date")]
        public DateTime SacramentDate { get; set; }

        [Required]
        [Display(Name = "Conduncting")]
        public string ConductingBishopric { get; set; }

        [Required]
        [Display(Name = "Opening Prayer")]
        public string OpeningPrayer { get; set; }

        [Required]
        [Display(Name = "Opening Hymn")]
        public string OpeningHymn { get; set; }

        [Required]
        [Display(Name = "Sacrament Hymn")]
        public string SacramentHymn { get; set; }


        [Display(Name = "Intermediate Hymn")]
        public string IntermediateHymn { get; set; }

        [Required]
        [Display(Name = "Closing Hymn")]
        public string ClosingHymn { get; set; }

        [Required]
        [Display(Name = "Closing Prayer")]
        public string ClosingPrayer { get; set; }
       
        public ICollection<Member> Speaker { get; set; }
    }
}
