using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace MegaDesk_Hull
{
    public partial class searchQuotes : Form
    {
        List<DeskQuotes> desk;
        
        public searchQuotes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainMenu mm = (MainMenu)Tag;
            mm.Show();
            Close();
        }
       
        private void searchQuotes_Load(object sender, EventArgs e)
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "Data\\quotes.json");
            // get all the text in the file
            string jsonFile = File.ReadAllText(path);
            // deserialize json into list of DeskQuotes class 
            desk = JsonConvert.DeserializeObject<List<DeskQuotes>>(jsonFile);
            // setup table and columns
            DataTable quoteData = new DataTable();
            quoteData.Columns.Add("Name");
            quoteData.Columns.Add("Date");
            quoteData.Columns.Add("Drawer Number");
            quoteData.Columns.Add("Surface Material");
            quoteData.Columns.Add("Total");
            dataGridView1.DataSource = quoteData;
            // add rows of data
            for (int i = 0; i < desk.Count; i++)
            {
                string[] row = new string[] { desk[i].Name, 
                    desk[i].QuoteDate.ToString(" dd MMMM  yyyy"), desk[i].Desk.Drawer.ToString(),
                    desk[i].Desk.Material, desk[i].TotalPrice.ToString()};
                quoteData.Rows.Add(row);
            }
        }

        private void inputMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            DataTable searchData = new DataTable();
            searchData.Columns.Add("Name");
            searchData.Columns.Add("Date");
            searchData.Columns.Add("Drawer Number");
            searchData.Columns.Add("Surface Material");
            searchData.Columns.Add("Total");
            dataGridView1.DataSource = searchData;
            for (int i = 0; i < desk.Count; i++)
            {
                if (desk[i].Desk.Material == inputMaterial.Text)
                {
                    string[] row = new string[] { desk[i].Name,
                    desk[i].QuoteDate.ToString(" dd MMMM  yyyy"), desk[i].Desk.Drawer.ToString(),
                    desk[i].Desk.Material, desk[i].TotalPrice.ToString()};
                    searchData.Rows.Add(row);
                }
            }
        }
    }
}
