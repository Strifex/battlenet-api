using System.Collections.Generic;

namespace battlenet_api.Models.Starcraft
{
    public class Category
    {
        public string title { get; set; }
        public int categoryId { get; set; }
        public long featuredAchievementId { get; set; }
        public List<Category> children { get; set; }
    }
}
