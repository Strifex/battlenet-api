namespace battlenet_api.Models.Warcraft
{
    public class Items
    {
        public int averageItemLevel { get; set; }
        public int averageItemLevelEquipped { get; set; }
        public Equipment head { get; set; }
        public Equipment neck { get; set; }
        public Equipment shoulder { get; set; }
        public Equipment back { get; set; }
        public Equipment chest { get; set; }
        public Equipment shirt { get; set; }
        public Equipment wrist { get; set; }
        public Equipment hands { get; set; }
        public Equipment waist { get; set; }
        public Equipment legs { get; set; }
        public Equipment feet { get; set; }
        public Equipment finger1 { get; set; }
        public Equipment finger2 { get; set; }
        public Equipment trinket1 { get; set; }
        public Equipment trinket2 { get; set; }
        public Equipment mainHand { get; set; }
        public Equipment offHand { get; set; }
    }
}
