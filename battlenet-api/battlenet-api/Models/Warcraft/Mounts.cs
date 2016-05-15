using System.Collections.Generic;

namespace battlenet_api.Models.Warcraft
{
    public class Mounts
    {
        public int numCollected { get; set; }
        public int numNotCollected { get; set; }
        public List<Mount> collected { get; set; }
    }
}
