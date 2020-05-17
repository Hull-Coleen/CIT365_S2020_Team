using System;
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

        public DeskQuotes(Desk desk, DateTime quoteDate, string name, int rushDays, string[,] rushOrders)
        {
            this.desk = desk;
            this.quoteDate = quoteDate;
            this.name = name;
            this.rushDays = rushDays;
            this.rushOrders = rushOrders;
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
           // MessageBox.Show("get size" + desk.getWidth().ToString() + " depth" + desk.getDepth().ToString());
            if (extraSize > 0)
            {
                return extraSize;
            }
            else
            {
                return includedSize;
            }
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
        public double getQuotePrice(string drawer, int material)
        {
            
            return 200 + drawerCost(drawer) + getSize() + material;
            //return 200 + drawerCost(drawer) + getSize() + materialCost(material);
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

    }
}
