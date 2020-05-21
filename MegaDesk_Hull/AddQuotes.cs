using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace MegaDesk_Hull
{
    
    public partial class AddQuotes : Form
    {
        //instaniate DeskQuote
        DeskQuotes deskQ = new DeskQuotes();
        int selectedKey = 0;

        internal DeskQuotes DeskQ { get => deskQ; set => deskQ = value; }

        public AddQuotes()
        {
            InitializeComponent();
            saveButton.Enabled = false;
        }
        // only allows keys that are digits to be input into the textbox
        public void keyPressFunction(KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                MessageBox.Show("please enter digits only");
                e.Handled = true;
            }
        }
        // key events calling KeyPressFunction
        private void inputDepth_KeyPress(object sender, KeyPressEventArgs e) => keyPressFunction(e);
        // key events calling KeyPressFunction
        private void inputWidth_KeyPress(object sender, KeyPressEventArgs e) => keyPressFunction(e);
        // gathers all the information needed to to display quote information in Display quotes form
        // opens json file and adds new quote and writes back ot json file and calls displayquotes form
        private void SaveButton_Click(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            deskQ.Name = inputName.Text;
            //deskQ.QuoteDate = currentTime;
            deskQ.TotalPrice = deskQ.getQuotePrice(inputDrawer.Text,
                  selectedKey, shippingInput.Text);
            deskQ.Shipping = deskQ.getShippingPrice(shippingInput.Text);
            
            // get the location of the file
            string path = Path.Combine(Directory.GetCurrentDirectory(), "Data\\quotes.json");

            // get all the text in the file
            string jsonFile = File.ReadAllText(path);
           // deserialize json into list of DeskQuotes class and add new instance
            List<DeskQuotes> desk = JsonConvert.DeserializeObject<List<DeskQuotes>>(jsonFile);
            desk.Add(deskQ);
            // convert back to json
            var convertedJson = JsonConvert.SerializeObject(desk, Formatting.Indented);
            // write updated json file to quotes.json
            File.WriteAllText(path, convertedJson);

            DisplayQuotes viewDisplayQuotes = new DisplayQuotes();
            viewDisplayQuotes.Tag = this;
            viewDisplayQuotes.Show(this);
        }
        // converts enum into a Key pair list and returns the list
        public List<KeyValuePair<string, int>> GetEnumList<T>()
        {
            var list = new List<KeyValuePair<string, int>>();
            foreach (var e in Enum.GetValues(typeof(T)))
            {
                list.Add(new KeyValuePair<string, int>(e.ToString(), (int)e));
            }
            return list;
        }
        // assigns list of enum values to the inputMaterial combo box
        private void AddQuotes_Load(object sender, EventArgs e)
        {
            //assign the material enum 
            List<KeyValuePair<string, int>> materialList = GetEnumList<Material>();
            // make the meterailList(enum material) the datasource and assign key and value
            inputMaterial.DataSource = materialList;
            inputMaterial.DisplayMember= "Key";
            inputMaterial.ValueMember =  "Value";
          
            // set values to price labels 
            materialCostPrice.Text = inputMaterial.SelectedValue.ToString();
        }
        // assigns a value to totalCostPrice label
        private void costUpdate()
        {
            totalCostPrice.Text = deskQ.getQuotePrice(inputDrawer.Text,
                  selectedKey, shippingInput.Text).ToString();
        }
        // takes the input from inputMaterial combo box and using the key pair list of enums and assigns text 
        // to the materialCostPrice label and in Desk Class set the values for material and materialCost
        private void inputMaterial_changed(object sender, EventArgs e)
        {
            materialCostPrice.Text = inputMaterial.SelectedValue.ToString();

            KeyValuePair<string, int> selectedEntry
                 = (KeyValuePair<string, int>)inputMaterial.SelectedItem;
            selectedKey = selectedEntry.Value;
            string selectedValue = selectedEntry.Key;
            deskQ.Desk.Material = selectedValue;
            deskQ.Desk.MaterialCost = selectedKey;
            costUpdate();

        }
        // checks to see if a number is valid
        public bool numberValid(int smallBound, int largeBound, int userInput, out string errMess)
        {
            if(userInput < smallBound || userInput > largeBound)
            {
                errMess = $" please enter numbers between {smallBound} and {largeBound}";
                return false;
            }
            errMess = "";
            return true; 
        }
        // checks to see if a number is valid
        public bool numberValid(int smallBound, int largeBound, int userInput)
        {
            if (userInput < smallBound || userInput > largeBound)
            {
                return false;
            }
            return true;
        }
        // sets error if input is in valid
        private void inputDepth_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(inputDepth, "");
        }

        private void inputDepth_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            int depth = 0;
            try
            {
                depth = Int32.Parse(inputDepth.Text);
            }
            catch (Exception)
            {
                errorMsg = "could not convert string to int";
                errorProvider1.SetError(inputDepth, errorMsg);
            }
            if (!numberValid(Constants.SmallDepth, Constants.LargeDepth, depth, out errorMsg))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                inputDepth.Select(0, inputDepth.Text.Length);

                // Set the ErrorProvider error with the text to display. 
                errorProvider1.SetError(inputDepth, errorMsg);

            }
            deskQ.Desk.Depth = depth;
            costUpdate();
            overCostPrice.Text = deskQ.getSize().ToString();
            buttonEnable();
        }
        private void inputWidth_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            int width = 0;
            try
            {
                width = Int32.Parse(inputWidth.Text);
            }
            catch (Exception)
            {
                errorMsg = "could not convert string to int";
                errorProvider1.SetError(inputWidth, errorMsg);
            }
            if(!numberValid(Constants.SmallWidth, Constants.LargeWidth, width, out errorMsg))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                inputWidth.Select(0, inputWidth.Text.Length);

                // Set the ErrorProvider error with the text to display. 
                errorProvider1.SetError(inputWidth, errorMsg);

            }
            deskQ.Desk.Width = width;
            costUpdate();
            overCostPrice.Text = deskQ.getSize().ToString();
            buttonEnable();
        }

        private void inputWidth_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(inputWidth, "");
        }

        private void inputName_Validating(object sender, CancelEventArgs e)
        {
            if (!validName(inputName.Text, out string errorMsg))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                inputName.Select(0, inputName.Text.Length);

                // Set the ErrorProvider error with the text to display. 
                errorProvider1.SetError(inputName, errorMsg);
            }
            buttonEnable();

        }

        private void inputName_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(inputName, "");

        }

        private bool validName(string name, out string errorMessage)
        {
            // Confirm that the name string is not empty.
            if (name.Length == 0)
            {
                errorMessage = "A name is required.";
                return false;
            }
            errorMessage = "";
            return true;
        }
        public bool validName(string name)
        {
            // Confirm that the name string is not empty.
            if (name.Length == 0)
            {
                return false;
            }
            return true;
        }
        
        private void shippingInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            // get the location of the file
            string path = Path.Combine(Directory.GetCurrentDirectory(), "Data\\rushOrderPrices.txt");

            // convert file to a string array
            string[] rushOrderFile = File.ReadAllLines(path, Encoding.UTF8);

            // populate the rushOrder variable
            deskQ.getRushOrder(rushOrderFile);
            shippingCostPrice.Text = deskQ.getShippingPrice(shippingInput.Text).ToString();
            buttonEnable();
            costUpdate();
        }
        private void inputDrawer_SelectedIndexChanged(object sender, EventArgs e)
        {
            drawerNumPrice.Text = deskQ.drawerCost(inputDrawer.Text).ToString();
            deskQ.Desk.Drawer = int.Parse(inputDrawer.Text);
            costUpdate();
        }
        private void buttonEnable()
        { 
            if (validName(inputName.Text) && (shippingInput.Text != "") && 
                numberValid(Constants.SmallDepth, Constants.LargeDepth, int.Parse(inputDepth.Text))
                && numberValid(Constants.SmallWidth, Constants.LargeWidth, int.Parse(inputWidth.Text)))
                saveButton.Enabled = true;

        }
        private void resetButton_Click(object sender, EventArgs e)
        {
            deskQ = new DeskQuotes();
            inputName.Text = "";
            inputWidth.Text = "";
            inputDepth.Text = "";
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            MainMenu mm = (MainMenu)Tag;
            mm.Show();
            Close();
        }
    }
}
