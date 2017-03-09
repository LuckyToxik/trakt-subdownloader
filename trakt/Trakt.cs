using HtmlAgilityPack;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trakt
{
    class Trakt
    {
        static authjs authjs { get; set; }
        static AccessToken access { get; set; }
        static Uri baseAddress { get; set; }
        static Form1 form { get; set; }


        public Trakt(Form1 f)
        {
            baseAddress = new Uri("https://api.trakt.tv/");
            authjs = new authjs();
            access = new AccessToken();
            form = f;
            


        }
        
        public async void getLoginToken(string pin)
        {
            using (var httpClient = new HttpClient { BaseAddress = baseAddress })
            {
                authjs.code = pin;
                string json = JsonConvert.SerializeObject(authjs);
                using (var content = new StringContent(json, System.Text.Encoding.Default, "application/json"))
                {
                    using (var response = await httpClient.PostAsync("oauth/token", content))
                    {
                        string responseData = await response.Content.ReadAsStringAsync();
                        AccessToken obj = JsonConvert.DeserializeObject<AccessToken>(responseData);

                        access.access_token = obj.access_token;

                    }
                }

            }
        }


        public async void ListShows(string user, string list){
            try {
                using (var httpClient = new HttpClient { BaseAddress = baseAddress })
                {


                    httpClient.DefaultRequestHeaders.TryAddWithoutValidation("trakt-api-version", "2");

                    httpClient.DefaultRequestHeaders.TryAddWithoutValidation("trakt-api-key", authjs.client_id);

                    using (var response = await httpClient.GetAsync("users/"+user+"/lists/" + list + "/items/shows"))
                    {

                        string responseData = await response.Content.ReadAsStringAsync();

                        var show = JsonConvert.DeserializeObject<List<TvShow>>(responseData);

                        HtmlWeb hw = new HtmlWeb();
                        HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                        doc = hw.Load("http://www.tvguru.cz/");

                        for (int i = 0; i < show.Count; i++)
                        {

                            ListViewItem item = new ListViewItem(show[i].show.title);





                            using (var response_s = await httpClient.GetAsync("shows/" + show[i].show.ids.trakt + "/last_episode"))
                            {

                                string responseData_s = await response_s.Content.ReadAsStringAsync();
                                var last = JsonConvert.DeserializeObject<LastEpisode>(responseData_s);


                                item.SubItems.Add(last.number.ToString() + "x" + last.season.ToString() + " " + last.title);



                               

                                foreach (HtmlNode link in doc.DocumentNode.SelectNodes("//a[@href]"))
                                {



                                        string showname_c = show[i].show.title.Replace(" ", "-");
                                        string showname = showname_c.Replace("-DC's", "");

                                        

                                    string ep = last.number.ToString("D2");
                                    string se = last.season.ToString("D2");

                                    string c_show = showname + "-s" + se + "e" + ep;

                                    string hrefValue = link.GetAttributeValue("href", string.Empty);

                                        if(hrefValue.Contains(c_show.ToLower()))
                                    {
                                        item.SubItems.Add(hrefValue);
                                        item.SubItems.Add("ANO");
                                    }
                                    
                                        


                                }






                            }
                            form.listview.Items.Add(item);

                        }




                    }
                }
            }
            catch(Exception e) {
                MessageBox.Show(e.ToString());
            }






        }

      




    }
}
        

            

            
