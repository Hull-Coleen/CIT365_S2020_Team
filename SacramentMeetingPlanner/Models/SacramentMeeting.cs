using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [Display(Name = "Invocation")]
        public string OpeningPrayer { get; set; }

        [Required]
        [Display(Name = "Opening Hymn")]
       
        public string OpeningHymnId { get; set; }

        [Required]
        [Display(Name = "Sacrament Hymn")]
        
        public string SacramentHymnId { get; set; }


        [Display(Name = "Intermediate Hymn")]
        public string IntermediateHymn { get; set; }

        [Required]
        [Display(Name = "Closing Hymn")]
        public string ClosingHymnId { get; set; }

        [Required]
        [Display(Name = "Benediction")]
        public string ClosingPrayer { get; set; }
        [Required]
        public string Topic { get; set; }
        [Display(Name = "Youth Speaker")]
        public string Speaker1 { get; set; }
        [Display(Name = "Speaker")]
        public string Speaker2 { get; set; }
        [Display(Name = "Speaker")]
        public string Speaker3 { get; set; }
        [Display(Name = "Speaker")]
        public string Speaker4 { get; set; }
        [Display(Name = "Speaker")]
        public string Speaker5 { get; set; }
        [Display(Name = "Speaker")]
        public string Speaker6 { get; set; }

        public ICollection<Speaker> Speaker { get; set; }
        // public virtual Hymn Hymn { get; set; }
       // public virtual Hymn ClosingHymnNavigation { get; set; }

       // public virtual Hymn OpeningHymnNavigation { get; set; }

       // public virtual Hymn SacramentHymnNavigation { get; set; }

    }
}
