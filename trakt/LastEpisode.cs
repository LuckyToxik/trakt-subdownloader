using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trakt
{
    class LastEpisode
    {

        public int season { get; set; }
        public int number { get; set; }
        public string title { get; set; }
        public Ids ids { get; set; }

        public class Ids
        {
            public int trakt { get; set; }
            public int tvdb { get; set; }
            public string imdb { get; set; }
            public int tmdb { get; set; }
            public int tvrage { get; set; }
        }
    }
}
