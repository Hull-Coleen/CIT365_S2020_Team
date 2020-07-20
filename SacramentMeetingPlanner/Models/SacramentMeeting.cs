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
        [Display(Name = "Conducting")]
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
        [Required]
        public string Topic { get; set; } 
        public string Speaker1 { get; set; }
        public string Speaker2 { get; set; }
        public string Speaker3 { get; set; }
        public string Speaker4 { get; set; }
        public string Speaker5 { get; set; }
        public string Speaker6 { get; set; }

        public ICollection<Speaker> Speaker { get; set; }

    }
}
