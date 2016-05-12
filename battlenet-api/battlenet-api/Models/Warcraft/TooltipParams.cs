using System.Collections.Generic;

namespace battlenet_api.Models.Warcraft
{
    public class TooltipParams
    {
        public List<int> set { get; set; }
        public int gem0 { get; set; }
        public int enchant { get; set; }
        public int transmogItem { get; set; }
        public Upgrade upgrade { get; set; }
        public int timewalkerLevel { get; set; }
    }
}
