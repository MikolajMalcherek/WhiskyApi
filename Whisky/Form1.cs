using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Windows.Forms;
using System.Text.Json;
using System.Net.Http;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Whisky
{
    public partial class Form1 : Form
    {
        private DistilleryDbContext? DbContext;
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.DbContext = new DistilleryDbContext();
        }



        private async Task<string> downloadData()
        {
            HttpClient client = new HttpClient();
            string call = "https://whiskyhunter.net/api/distilleries_info/";
            string json = await client.GetStringAsync(call);
            return json;
        }

        public void clear_database()
        {
            foreach (var dist in DbContext.DistDB)
                DbContext.Remove(dist);
            DbContext.SaveChanges();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string json = await downloadData();
            var dists = JsonSerializer.Deserialize<List<Distillery>>(json);

            clear_database();

            foreach (var dist in dists)
            {
                listBox2.Items.Add(dist.name);
            }

            foreach (var dist in dists)
            {
                DbContext.DistDB.Add(dist);
                await DbContext.SaveChangesAsync();
            }


            listBox1.Items.Clear();
            foreach (var dist in DbContext.DistDB)
            {
                if (dist.name == textBox2.Text)
                {
                    listBox1.Items.Add(dist);
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}