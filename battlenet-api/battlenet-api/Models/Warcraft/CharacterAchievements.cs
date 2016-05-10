using System.Collections.Generic;

namespace battlenet_api.Models.Warcraft
{
    public class CharacterAchievements
    {
        public List<int> achievementsCompleted { get; set; }
        public List<long> achievementsCompletedTimestamp { get; set; }
        public List<int> criteria { get; set; }
        public List<long> criteriaQuantity { get; set; }
        public List<long> criteriaTimestamp { get; set; }
        public List<long> criteriaCreated { get; set; }
    }
}
