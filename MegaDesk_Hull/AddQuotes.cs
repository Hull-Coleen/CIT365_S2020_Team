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
        //instaniate DeskQuote
        DeskQuotes deskQ = new DeskQuotes();
        int selectedKey = 0;
        public AddQuotes()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
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
                deskQ.getDesk().setWidth(width);
                totalCostPrice.Text = deskQ.getQuotePrice(inputDrawer.Text,
                         selectedKey).ToString();
               // MessageBox.Show("width val"  + deskQ.getSize().ToString());
            }
            catch (Exception)
            {
                e.Cancel = true;
                if (width < 24 || width > 96)
                {
                    MessageBox.Show("Please enter numbers between 24 and 96");
                }
                else
                {
                    MessageBox.Show("Please enter only numbers into the width field");
                }
            }
        }
        
        private void inputDepth_KeyPress(object sender, KeyPressEventArgs e)
        {
             if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
             {
                MessageBox.Show("please enter digits only");
                e.Handled = true;
             }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
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
            //assign the material enum 
            List<KeyValuePair<string, int>> materialList = GetEnumList<Material>();
            // make the meterailList(enum material) the datasource and assign key and value
            inputMaterial.DataSource = materialList;
            inputMaterial.DisplayMember= "Key";
            inputMaterial.ValueMember =  "Value";
            // set values to price labels
            overCostPrice.Text = deskQ.getSize().ToString(); 
            materialCostPrice.Text = inputMaterial.SelectedValue.ToString();
           // materialCostPrice.Text = inputMaterial.SelectedValue.ToString();
            drawerNumPrice.Text = deskQ.getDesk().getDrawer().ToString();
        
            // get the location of the file
            string path = Path.Combine(Directory.GetCurrentDirectory(), "Data\\rushOrder.txt");
            
            // convert file to a string array
            string [] rushOrderFile = File.ReadAllLines(path, Encoding.UTF8);
            //string[] rushOrderFile = File.ReadAllLines("rushOrder.txt", Encoding.UTF8);
            // populate the rushOrder variable
            string [,] rushOrderPrice = deskQ.getRushOrder(rushOrderFile);
            // name.Text = rushOrderPrice[0, 1].ToString();

            //string path = Path.Combine(Directory.GetCurrentDirectory(), @"MegaDesk_Hull\rushOrder.txt");
            //string path = Environment.CurrentDirectory + @"\Data\rushOrderPrices.txt";
            //string path = Directory.GetCurrentDirectory() + "\\Data\rushOrderPrices.txt";
            // string path = @"\Data\rushOrderPrices.txt";

        }

        private void inputMaterial_changed(object sender, EventArgs e)
        {
            materialCostPrice.Text = inputMaterial.SelectedValue.ToString();

            KeyValuePair<string, int> selectedEntry
                 = (KeyValuePair<string, int>)inputMaterial.SelectedItem;
            selectedKey = selectedEntry.Value;
            totalCostPrice.Text = deskQ.getQuotePrice(inputDrawer.Text, 
                 selectedKey).ToString();



        }


        private void inputDrawer_SelectedIndexChanged(object sender, EventArgs e)
        {
            drawerNumPrice.Text = deskQ.drawerCost(inputDrawer.Text).ToString();
            totalCostPrice.Text = deskQ.getQuotePrice(inputDrawer.Text, 
               selectedKey).ToString();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            deskQ = new DeskQuotes();
            //totalCostPrice.Text = deskQ.getQuotePrice(inputDrawer.Text,
               // inputMaterial.SelectedValue.ToString()).ToString();
        }

        private void inputDepth_TextChanged(object sender, EventArgs e)
        {

            int.TryParse(inputDepth.Text, out int input);
            deskQ.getDesk().setDepth(input);
            totalCostPrice.Text = deskQ.getQuotePrice(inputDrawer.Text,
               selectedKey).ToString();
           // MessageBox.Show("Key Press" + deskQ.getSize().ToString());
            overCostPrice.Text = deskQ.getSize().ToString();
        }
    }
}
