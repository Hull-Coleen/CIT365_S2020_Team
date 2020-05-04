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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddQuotes addQ = new AddQuotes();
            addQ.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            viewAllQuotes viewQ = new viewAllQuotes();
            viewQ.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            searchQuotes searchQ = new searchQuotes();
            searchQ.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
