using System;
using System.Windows.Forms;
using trakt.Properties;
using HtmlAgilityPack;
using System.Collections.Generic;
using System.Net;
using System.Text.RegularExpressions;

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

            if(text_listname.Text != "" && text_username.Text != "")
                trakt.ListShows(text_username.Text, text_listname.Text);

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

        private void button_search_Click(object sender, EventArgs e)
        {



            //string word = "The Walking Dead S07E12";
            //string source = (new WebClient()).DownloadString("http://tvguru.cz/");
            //if (source.Contains(word))
            //    MessageBox.Show("Found it " + word);

           




        }






    }
}
