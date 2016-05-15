namespace battlenet_api.Models.Warcraft
{
    public class Pet
    {
        public string name { get; set; }
        public int spellId { get; set; }
        public int creatureId { get; set; }
        public int itemId { get; set; }
        public int qualityId { get; set; }
        public string icon { get; set; }
        public PetStats stats { get; set; }
        public string battlePetGuid { get; set; }
        public bool isFavorite { get; set; }
        public bool isFirstAbilitySlotSelected { get; set; }
        public bool isSecondAbilitySlotSelected { get; set; }
        public bool isThirdAbilitySlotSelected { get; set; }
        public string creatureName { get; set; }
        public bool canBattle { get; set; }
    }
}
