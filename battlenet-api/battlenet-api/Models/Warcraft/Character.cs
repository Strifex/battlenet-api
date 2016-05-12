using System.Collections.Generic;

namespace battlenet_api.Models.Warcraft
{
    public enum CharacterFields
    {
        Achievements,
        Appearance,
        Feed,
        Guild,
        HunterPets,
        Items,
        Mounts,
        Pets,
        PetSlots,
        Progression,
        PvP,
        Quests,
        Reputation,
        Statistics,
        Stats,
        Talents,
        Titles,
        Audit
    }

    public class Character
    {
        public long lastModified { get; set; }
        public string name { get; set; }
        public string realm { get; set; }
        public string battlegroup { get; set; }
        public int @class { get; set; }
        public int race { get; set; }
        public int gender { get; set; }
        public int level { get; set; }
        public int achievementPoints { get; set; }
        public string thumbnail { get; set; }
        public string calcClass { get; set; }
        public int faction { get; set; }
        public CharacterAchievements achievements { get; set; }
        public List<Feed> feed { get; set; }
        public Appearance appearance { get; set; }
        public Items items { get; set; }
        public int totalHonorableKills { get; set; }
    }
}
