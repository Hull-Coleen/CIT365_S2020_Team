using System;
using System.Windows.Forms;

namespace MegaDesk_Hull
{
    public partial class DisplayQuotes : Form
    { 
        public DisplayQuotes()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            ((AddQuotes)Tag).Show();
            Close();
        }

        private void DisplayQuotes_Load(object sender, EventArgs e)
        {
            // set values.
            customerLabel.Text = ((AddQuotes)Tag).DeskQ.Name;
            dateLabel.Text = ((AddQuotes)Tag).DeskQ.QuoteDate.ToString(" dd MMMM  yyyy");
            materialLabel.Text = ((AddQuotes)Tag).DeskQ.Desk.Material;
            materialCost.Text = "$  " + ((AddQuotes)Tag).DeskQ.Desk.MaterialCost.ToString("N0");
            overSizeCostLabel.Text = "$  " + ((AddQuotes)Tag).DeskQ.getSize().ToString("N0");
            drawerCostLabel.Text = ((AddQuotes)Tag).DeskQ.Desk.Drawer.ToString();
            shippingCostLabel.Text = "$  " +((AddQuotes)Tag).DeskQ.Shipping.ToString("N0");
            totalPriceCostLabel.Text = "$  " + ((AddQuotes)Tag).DeskQ.TotalPrice.ToString("N0");


        }
    }
}
