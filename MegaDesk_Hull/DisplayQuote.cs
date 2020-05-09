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
    public partial class DisplayQuote : Form
    {
        private void backButton_Click(object sender, EventArgs e)
        {
            AddQuotes AddQ = (AddQuotes)Tag;
            AddQ.Show();
            Close();
        }
    }
}
