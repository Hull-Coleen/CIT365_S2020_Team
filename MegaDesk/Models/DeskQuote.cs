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

        public double cost()
        {
            int size = Width * Depth;
            if (size > 1000)
            {
                size = Width * Depth - 1000;
            }
            else 
                size = 0;
            int MaterialCost = 0;
            if (Material == "Pine")
                MaterialCost = 50;
            else if (Material == "Oak")
                MaterialCost = 100;
            else if (Material == "Veneer")
                MaterialCost = 150;
            else if (Material == "Laminate")
                MaterialCost = 175;
            else if(Material == "Rosewood")
                    MaterialCost = 300;
            return 200.00 + (DrawerNumber * 50) + size + MaterialCost;
        }
        public double cost(string material, int width, int depth, int drawer)
        {
            int size = width * depth;
            if (size > 1000)
            {
                size = width * depth - 1000;
            }
            else
                size = 0;
            int MaterialCost = 0;
            if (material == "Pine")
                MaterialCost = 50;
            else if (material == "Oak")
                MaterialCost = 100;
            else if (material == "Veneer")
                MaterialCost = 150;
            else if (material == "Laminate")
                MaterialCost = 175;
            else if (material == "Rosewood")
                MaterialCost = 300;
            return 200.00 + (drawer * 50) + size + MaterialCost;
        }
    }
}
