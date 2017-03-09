using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using trakt.Properties;

namespace trakt
{
   public partial class Form1 : Form
    {
        static authjs authjs { get; set; }
        static AccessToken access { get; set; }

        static Trakt trakt { get; set; }


        public Form1()
        {
            InitializeComponent();
            trakt = new Trakt(this);

            

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            text_username.Text = Settings.Default["username"].ToString();
            text_listname.Text = Settings.Default["listname"].ToString();

        }
        private void Form1_Closing(object sender, FormClosingEventArgs e)
        {
            Settings.Default["username"] = text_username.Text;
            Settings.Default["listname"] = text_listname.Text;
            Settings.Default.Save();
        }

        private void ShowShows_Click(object sender, EventArgs e)
        {
            trakt.ListShows(text_username.Text,text_listname.Text);
           
        }


        private void listview_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
