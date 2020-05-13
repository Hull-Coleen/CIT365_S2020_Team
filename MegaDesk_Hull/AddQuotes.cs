using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


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
        private void inputDepth_KeyUp(object sender, KeyPressEventArgs e)
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
        public List<KeyValuePair<string, int>> GetEnumList<T>()
        {
            var list = new List<KeyValuePair<string, int>>();
            foreach (var e in Enum.GetValues(typeof(T)))
            {
                list.Add(new KeyValuePair<string, int>(e.ToString(), (int)e));
            }
            return list;
        }
        private void AddQuotes_Load(object sender, EventArgs e)
        {
            Desk desk = new Desk();
            List<Material> materialList = new List<Material>();
            materialList.Add(Material.Laminate);
            materialList.Add(Material.Pine);
            materialList.Add(Material.Veneer);
            materialList.Add(Material.Oak);
            materialList.Add(Material.Rosewood);
           // inputMaterial.DataSource = materialList;
            //inputMaterial.DisplayMember = materialList.GetEnumerator().Current
            //inputMaterial.ValueMember = materialList;
            List<KeyValuePair<string, int>> list = GetEnumList<Material>();
            inputMaterial.DataSource = list;
           // inputMaterial.DisplayMember = list.Enum.GetValues;
            //inputMaterial.DisplayMember = materialList.GetEnumerator().Current

            // get the location of the file
            string path = Path.Combine(Directory.GetCurrentDirectory(), "Data\\rushOrderPrices.txt");
            // convert file to a string array
            string [] rushOrderFile = File.ReadAllLines(path, Encoding.UTF8);
            // name.Text = content[0];
            //name.Text = materialList[0].ToString();
        }

        private void inputMaterial_ValueMemberChanged(object sender, EventArgs e)
        {

        }

    }
}
