using System.Collections.Generic;

namespace battlenet_api.Models.Warcraft
{
    public class Feed
    {
        public string type { get; set; }
        public long timestamp { get; set; }
        public int itemId { get; set; }
        public string context { get; set; }
        public List<object> bonusLists { get; set; }
        public Achievement achievement { get; set; }
        public bool? featOfStrength { get; set; }
        public Criteria criteria { get; set; }
        public int? quantity { get; set; }
        public string name { get; set; }
    }
}
