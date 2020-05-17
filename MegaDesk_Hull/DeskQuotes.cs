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
        private int rushDays;
        private string [,] rushOrders;
        public DeskQuotes()
        {
            desk = new Desk();
            name = "";
            rushDays = 0;

        }

        public DeskQuotes(Desk desk, DateTime quoteDate, string name, int rushDays)
        {
            this.desk = desk;
            this.quoteDate = quoteDate;
            this.name = name;
            this.rushDays = rushDays;

        }

        public string getName() { return name; }
        public int getRushDays() { return rushDays; }
        public DateTime getQuoteDate() { return quoteDate; }
        public Desk getDesk() { return desk; }
        public void setName(string name) {
            this.name = name; 
        }
        public void setRushDays(int day) {
            this.rushDays = day;
        }
        public void setQuoteDate(DateTime date)
        {
            this.quoteDate = date; 
        }
        public void setDesk(Desk desk) {
            this.desk = desk; 
        }
        public double quotePrice() 
        {
            double price = 0;

            return price;
        }
        public double getSize()
        {
            double includedSize = 0;
            double extraSize = (desk.getWidth() * desk.getDepth()) - 1000;

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
        public double getRushPrice()
        {
            return 0;
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
