using System.Collections.Generic;

namespace battlenet_api.Models.Warcraft
{
    public class PetSlot
    {
        public int slot { get; set; }
        public string battlePetGuid { get; set; }
        public bool isEmpty { get; set; }
        public bool isLocked { get; set; }
        public List<int> abilities { get; set; }
    }
}
