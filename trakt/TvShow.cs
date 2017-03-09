using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trakt
{
    class TvShow
    {

        public int rank { get; set; }
        public string listed_at { get; set; }
        public string type { get; set; }
        public Show show { get; set; }

        public class Ids
        {
            public int trakt { get; set; }
            public string slug { get; set; }
            public int? tvdb { get; set; }
            public string imdb { get; set; }
            public int tmdb { get; set; }
            public int? tvrage { get; set; }
        }

        public class Show
        {
            public string title { get; set; }
            public int? year { get; set; }
            public Ids ids { get; set; }
        }




    }
            
}
