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
            var quoteData = table();
            deskQuotesDisplay.DataSource = quoteData;
            // enter items from json to data table
            for (int i = 0; i < desk.Count; i++)
            {
                var size = "W: " + desk[i].Desk.Depth.ToString() + " D: " + desk[i].Desk.Width.ToString();
                string[] row = new string[] { desk[i].Name, 
                    desk[i].QuoteDate.ToString(" dd MMMM  yyyy"), size, desk[i].Desk.Drawer.ToString(),
                    desk[i].Desk.Material, desk[i].TotalPrice.ToString("N0")};
                quoteData.Rows.Add(row);
            }
        }
        // creates a new table with columns and returns it
        private DataTable table()
        {
            DataTable dataTable = new DataTable();
            dataTable .Columns.Add("Name");
            dataTable.Columns.Add("Date");
            dataTable.Columns.Add("Dimensions");
            dataTable.Columns.Add("Drawer Number");
            dataTable.Columns.Add("Surface Material");
            dataTable.Columns.Add("Total");
            return dataTable;
        }
        private void inputMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            // assign new table 
            var searchData = table();
            deskQuotesDisplay.DataSource = searchData;
            //enter only items that match the search inpput
            for (int i = 0; i < desk.Count; i++)
            {
                var size = "W: " + desk[i].Desk.Depth.ToString() + " D: " + desk[i].Desk.Width.ToString();
                if (desk[i].Desk.Material == inputMaterial.Text)
                {
                    string[] row = new string[] { desk[i].Name,
                    desk[i].QuoteDate.ToString(" dd MMMM  yyyy"), size, desk[i].Desk.Drawer.ToString(),
                    desk[i].Desk.Material, desk[i].TotalPrice.ToString("N0")};
                    searchData.Rows.Add(row);
                }
            }
        }
    }
}
