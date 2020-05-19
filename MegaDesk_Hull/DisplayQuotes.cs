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
            customerLabel.Text = ((AddQuotes)Tag).DeskQ.Name;
            dateLabel.Text = ((AddQuotes)Tag).DeskQ.QuoteDate.ToString(" dd MMMM  yyyy");
            materialLabel.Text = ((AddQuotes)Tag).DeskQ.Desk.Material;
            materialCost.Text = ((AddQuotes)Tag).DeskQ.Desk.MaterialCost.ToString();
            overSizeCostLabel.Text = ((AddQuotes)Tag).DeskQ.getSize().ToString();
            //drawerCostLabel.Text = ((AddQuotes)Tag).DeskQ.drawerCost().ToString();
            drawerCostLabel.Text = ((AddQuotes)Tag).DeskQ.Desk.Drawer.ToString();
            shippingCostLabel.Text = ((AddQuotes)Tag).DeskQ.Shipping.ToString();
            totalPriceCostLabel.Text = ((AddQuotes)Tag).DeskQ.TotalPrice.ToString();

        }
    }
}
