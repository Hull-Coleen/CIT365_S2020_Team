using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Hull
{
    class DeskQuotes
    {
        private Desk desk;
        private DateTime quoteDate;
        private string name;
        private int shippingCost;
        private string [,] rushOrders;
        private double totalPrice;

        public DeskQuotes()
        {
            desk = new Desk();
            quoteDate= DateTime.Now;
            name = "";
            shippingCost = 0;
            rushOrders = new string [3,3];
            totalPrice = 0;
        }

        public string Name { get => name; set => this.name = value; }

        public int Shipping { get => shippingCost; set => this.shippingCost = value; }
        public DateTime QuoteDate { get => quoteDate; set => this.quoteDate = value; }

        public Desk Desk { get => desk; set => this.desk = value; }
        public double TotalPrice { get => totalPrice; set => totalPrice = value; }

        public double getSize()
        {
            double includedSize = 0;
            double extraSize = (desk.Width * desk.Depth) - 1000;

            return extraSize > 0 ? extraSize : includedSize;
        }

        public double drawerCost(string drawer)
        {
            int price = 0;
            if (drawer != string.Empty)
            {
                try
                {
                    price = Int32.Parse(drawer);
                }
                catch (Exception)
                {
                    MessageBox.Show("cannot convert string to int");
                }
                return price * 50;
            }
            return 0;
        }
        public double getQuotePrice(string drawer, int material, string day)
        {
            
            return 200 + drawerCost(drawer) + getSize() + material + getShippingPrice(day);
        }
        public string[,] getRushOrder(string [] dayPrice)
        {
            rushOrders = new string [3,3];
            int count = 0;
            try
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        rushOrders[i, j] = dayPrice[count];
                        count++;
                    }
                }
                return rushOrders;
            }
            catch(Exception)
            {
                throw new Exception("could not populate 2d array with input from file"); 
            }
        }
        
        public int getShippingPrice(string day)
        {
            switch (day)
            {
                case "Rush 3 Days":
                     if(getSize()  <= 0)
                    {
                        return int.Parse(rushOrders[0,0]);
                    }
                    else if (getSize() <= 1000)
                    {
                        return int.Parse(rushOrders[0, 1]);
                    }
                    else 
                        return int.Parse(rushOrders[0, 2]);
                // break;
                case "Rush 5 Days":
                     if (getSize() <= 0)
                    {
                        return int.Parse(rushOrders[1, 0]);
                    }
                    else if (getSize() <= 1000)
                    {
                        return int.Parse(rushOrders[1, 1]);
                    }
                    else
                        return int.Parse(rushOrders[1, 2]);
                    //break;
                case "Rush 7 Days":
                    if (getSize() <= 0)
                    {
                        return int.Parse(rushOrders[2, 0]);
                    }
                    else if (getSize() <= 1000)
                    {
                        return int.Parse(rushOrders[2, 1]);
                    }
                    else
                        return int.Parse(rushOrders[2, 2]);
                    //break;
                default:
                    return 0;
                    //break;

            }
            
        }


    }
}
