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
    public partial class AddQuotes : Form
    {
        public AddQuotes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainMenu mm = (MainMenu)Tag;
            mm.Show();
            Close();
        }

        private void inputWidth_Validating(object sender, CancelEventArgs e)
        {
            int width = 0;
            try 
            {
                width = Int32.Parse(inputWidth.Text);
            }
            catch(Exception)
            { 
                e.Cancel = true;
                MessageBox.Show("Please enter only numbers into the width field");
            }
            if (width < 24 || width > 96)
            {
                MessageBox.Show("Please enter numbers between 24 and 96");
            }
        }

        private void inputDepth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == 13)))
             {
                MessageBox.Show("please enter digits only");
                e.Handled = true;
             }
            if (Char.IsDigit(e.KeyChar) || (e.KeyChar == 13))
            {
               int.TryParse(inputDepth.Text, out int input);
                if (input > 9)
                {
                    if (input > 48 || input < 12)
                    {
                        MessageBox.Show("Please enter numbers between 12 and 48");
                    }
                }
            }
            
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            DisplayQuotes disQuote = new DisplayQuotes();
            disQuote.Tag = this;
            disQuote.Show(this);
            Hide();
        }
    }
}
