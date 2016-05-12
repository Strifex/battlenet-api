using System.Collections.Generic;

namespace battlenet_api.Models.Warcraft
{
    public class Equipment
    {
        public int id { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public int quality { get; set; }
        public int itemLevel { get; set; }
        public TooltipParams tooltipParams { get; set; }
        public List<Stat> stats { get; set; }
        public int armor { get; set; }
        public WeaponInfo weaponInfo { get; set; }
        public string context { get; set; }
        public List<int> bonusLists { get; set; }
    }
}
