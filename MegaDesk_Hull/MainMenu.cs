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
       
        private void searchQuotes_Click(object sender, EventArgs e)
        {
            
            searchQuotes searchQ = new searchQuotes();
            searchQ.Tag = this;
            searchQ.Show(this);
            this.Hide();
        }

        private void addQuote_Click(object sender, EventArgs e)
        {
            AddQuotes addQ = new AddQuotes();
            addQ.Tag = this;
            addQ.Show(this);
            this.Hide();  
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
