namespace battlenet_api.Models.Warcraft
{
    public class Guild
    {
        public string name { get; set; }
        public string realm { get; set; }
        public string battlegroup { get; set; }
        public int members { get; set; }
        public int achievementPoints { get; set; }
        public Emblem emblem { get; set; }
    }
}
