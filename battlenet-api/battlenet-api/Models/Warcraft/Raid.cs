using System.Collections.Generic;

namespace battlenet_api.Models.Warcraft
{
    public class Raid
    {
        public string name { get; set; }
        public int lfr { get; set; }
        public int normal { get; set; }
        public int heroic { get; set; }
        public int mythic { get; set; }
        public int id { get; set; }
        public List<Boss> bosses { get; set; }
    }
}
