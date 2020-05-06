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

        private void button2_Click(object sender, EventArgs e)
        {
            
            viewAllQuotes viewQ = new viewAllQuotes();
            viewQ.Show();
            //this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            searchQuotes searchQ = new searchQuotes();
            searchQ.Show();
            //this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addQuote_Click(object sender, EventArgs e)
        {
            AddQuotes addQ = new AddQuotes();
            addQ.Show();
           // this.Hide();
        }
    }
}
