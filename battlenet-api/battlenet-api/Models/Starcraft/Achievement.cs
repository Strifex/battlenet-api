namespace battlenet_api.Models.Starcraft
{
    public class Achievement
    {
        public string title { get; set; }
        public string description { get; set; }
        public long achievementId { get; set; }
        public int categoryId { get; set; }
        public int points { get; set; }
        public Icon icon { get; set; }
    }
}
