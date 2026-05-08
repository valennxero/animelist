using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

namespace animelist
{
    public class Anime
    {
        public string title { get; set; }

        public int mal_id { get; set; }
        public int? episodes { get; set; }
        public int? year { get; set; }
        public double? score { get; set; }
        public int? rank { get; set; }
        public string season { get; set; }
        public string synopsis { get; set; }
        public Images images { get; set; }

        public class Studios
        {
            public string name { get; set; }
        }

        public List<Studios> studios { get; set; }

        public class Genres
        {
            public string name { get; set; }
        }
        public List<Genres> genres { get; set; }

        public DateTime addedAdd { get; set; }

        public double myScore { get; set; }

        public string status { get; set; } // "Watching", "Completed", "On Hold", "Dropped", "Plan to Watch"

        public int epsWatched { get; set; }
}
}
