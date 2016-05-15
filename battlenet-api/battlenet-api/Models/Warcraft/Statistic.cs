namespace battlenet_api.Models.Warcraft
{
    public class Statistic
    {
        public int id { get; set; }
        public string name { get; set; }
        public long quantity { get; set; }
        public long lastUpdated { get; set; }
        public bool money { get; set; }
        public string highest { get; set; }
    }
}
