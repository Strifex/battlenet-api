using System.Collections.Generic;

namespace battlenet_api.Models.Warcraft
{
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
        public Guild guild { get; set; }
        public Appearance appearance { get; set; }
        public Items items { get; set; }
        public Mounts mounts { get; set; }
        public Pets pets { get; set; }
        public List<PetSlot> petSlots { get; set; }
        public Professions professions { get; set; }
        public Progression progression { get; set; }
        public PvP pvp { get; set; }
        public List<int> quests { get; set; }
        public List<Reputation> reputation { get; set; }
        public Statistics statistics { get; set; }
        public Stats stats { get; set; }
        public List<Talents> talents { get; set; }
        public List<Title> titles { get; set; }
        public string audit { get; set; }
        public int totalHonorableKills { get; set; }
    }

    public enum CharacterField
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
        Professions,
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

    public static class CharacterFieldsExtensions
    {
        public static string ToQueryString(this CharacterField field)
        {
            switch (field)
            {
                case CharacterField.Achievements:
                    return "achievements";
                case CharacterField.Appearance:
                    return "appearance";
                case CharacterField.Feed:
                    return "feed";
                case CharacterField.Guild:
                    return "guild";
                case CharacterField.HunterPets:
                    return "hunterPets";
                case CharacterField.Items:
                    return "items";
                case CharacterField.Mounts:
                    return "mounts";
                case CharacterField.Pets:
                    return "pets";
                case CharacterField.PetSlots:
                    return "petSlots";
                case CharacterField.Professions:
                    return "professions";
                case CharacterField.Progression:
                    return "progression";
                case CharacterField.PvP:
                    return "pvp";
                case CharacterField.Quests:
                    return "quests";
                case CharacterField.Reputation:
                    return "reputation";
                case CharacterField.Statistics:
                    return "statistics";
                case CharacterField.Stats:
                    return "stats";
                case CharacterField.Talents:
                    return "talents";
                case CharacterField.Titles:
                    return "titles";
                case CharacterField.Audit:
                    return "audit";
                default:
                    return string.Empty;
            }
        }
    }
}
