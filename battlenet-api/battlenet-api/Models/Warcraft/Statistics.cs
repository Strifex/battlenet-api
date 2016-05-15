using System.Collections.Generic;

namespace battlenet_api.Models.Warcraft
{
    public class Statistics
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<Statistic> statistics { get; set; }
        public List<Statistics> subCategories { get; set; }
    }
}
