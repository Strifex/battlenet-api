using System.Collections.Generic;

namespace battlenet_api.Models.Starcraft
{
    public class AchievementList
    {
        public List<Achievement> achievements { get; set; }
        public List<Category> categories { get; set; }
    }
}
