using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Hull
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        
        private void viewQuotes_Click(object sender, EventArgs e)
        {
            
            viewAllQuotes viewQ = new viewAllQuotes();
            viewQ.Show();
            //Close();
            //Close();
            //this.Hide();
        }
       
        private void searchQuotes_Click(object sender, EventArgs e)
        {
            
            searchQuotes searchQ = new searchQuotes();
            searchQ.Show();
            //Close();
            //this.Hide();
        }

        private void addQuote_Click(object sender, EventArgs e)
        {
            AddQuotes addQ = new AddQuotes();
            this.Hide();
            addQ.Show();
            //this.Close();
            
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
