using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Hull
{
    class DeskQuotes
    {
        private Desk desk;
        private DateTime quoteDate;
        private string name;
        private int rushDays;
        private int [,] rushOrders;
        public DeskQuotes()
        {
            desk = new Desk();
            name = "";
            rushDays = 0;

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
        public void getRushOrder(string [] dayPrice)
        {
            rushOrders = new int [3,3];
            int count = 0;
            
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    rushOrders[i, j] = Int32.Parse(dayPrice[count]);
                    count++;
                }
            }
        }

    }
}
