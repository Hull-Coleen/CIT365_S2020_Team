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
        [DataType(DataType.Date)]
        public DateTime QuoteDate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Width { get; set; }
        public int Depth { get; set; }
        public int DrawerNumber { get; set; }
        public string Material { get; set; }
        public decimal Cost { get; set; }
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
            return 200 + (DrawerNumber * 50) + size + MaterialCost;
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
            return 200 + (drawer * 50) + size + MaterialCost;
        }
    }
}
