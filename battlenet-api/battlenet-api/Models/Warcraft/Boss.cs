using System.Collections.Generic;

namespace battlenet_api.Models.Warcraft
{
    public class Boss
    {
        public int id { get; set; }
        public string name { get; set; }
        public string urlSlug { get; set; }
        public string description { get; set; }
        public int zoneId { get; set; }
        public bool availableInNormalMode { get; set; }
        public bool availableInHeroicMode { get; set; }
        public int health { get; set; }
        public int heroicHealth { get; set; }
        public int level { get; set; }
        public int heroicLevel { get; set; }
        public int journalId { get; set; }
        public List<Npc> npcs { get; set; }
        public Location location { get; set; }
    }
}
