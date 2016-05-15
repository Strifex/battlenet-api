namespace battlenet_api.Models.Warcraft
{
    public class ArenaBracket
    {
        public string slug { get; set; }
        public int rating { get; set; }
        public int weeklyPlayed { get; set; }
        public int weeklyWon { get; set; }
        public int weeklyLost { get; set; }
        public int seasonPlayed { get; set; }
        public int seasonWon { get; set; }
        public int seasonLost { get; set; }
    }
}
