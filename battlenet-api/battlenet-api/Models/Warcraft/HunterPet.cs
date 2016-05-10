namespace battlenet_api.Models.Warcraft
{
    public class HunterPet
    {
        public string name { get; set; }
        public int creature { get; set; }
        public bool selected { get; set; }
        public int slot { get; set; }
        public PetSpec spec { get; set; }
        public string calcSpec { get; set; }
        public int familyId { get; set; }
        public string familyName { get; set; }
    }
}
