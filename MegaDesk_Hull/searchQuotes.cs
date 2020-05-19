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
using Newtonsoft.Json;

namespace MegaDesk_Hull
{
    public partial class searchQuotes : Form
    {
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
            // deserialize json into list of DeskQuotes class and add new instance
            List<DeskQuotes> desk = JsonConvert.DeserializeObject<List<DeskQuotes>>(jsonFile);
        }
    }
}
