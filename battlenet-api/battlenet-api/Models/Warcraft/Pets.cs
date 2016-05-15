using System.Collections.Generic;

namespace battlenet_api.Models.Warcraft
{
    public class Pets
    {
        public int numCollected { get; set; }
        public int numNotCollected { get; set; }
        public List<Pet> collected { get; set; }
    }
}
