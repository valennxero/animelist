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
        public int? episodes { get; set; }
        public int? year { get; set; }
        public double? score { get; set; }
        public int? rank { get; set; }

        public Images images { get; set; }
    }
}
