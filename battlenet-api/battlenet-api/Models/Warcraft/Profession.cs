using System.Collections.Generic;

namespace battlenet_api.Models.Warcraft
{
    public class Profession
    {
        public int id { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public int rank { get; set; }
        public int max { get; set; }
        public List<int> recipes { get; set; }
    }
}
