using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace MegaDesk.Models
{
    public class DeskQuote
    {
        public int ID { get; set; }
        [Display(Name = "Quote Date")]
        [DataType(DataType.Date)]
        public DateTime QuoteDate { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        [Required]
        [Display(Name = "Name")]
        public string FirstName { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        [StringLength(60, MinimumLength = 3)]
        [Required]
        [Display(Name = "Last Name")] 
        public string LastName { get; set; }
        [Range(24, 96)]
        [Required]
        public int Width { get; set; }
        [Range(12, 48)]
        [Required]
        public int Depth { get; set; }
        [Display(Name = "Drawer #")]
        public int DrawerNumber { get; set; }
        public string Material { get; set; }
        [DataType(DataType.Currency)]
        public decimal Cost { get; set; }
        [Display(Name = "Ship Time")]
        public string Shipping { get; set; }

    }
}
