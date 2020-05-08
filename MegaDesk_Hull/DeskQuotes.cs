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

    }
}
