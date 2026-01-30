using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;


namespace animelist
{
    public class JikanRespon
    {
        public List<Anime> data { get; set; }
    }
}
