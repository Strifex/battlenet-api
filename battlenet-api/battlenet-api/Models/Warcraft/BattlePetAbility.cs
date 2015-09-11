namespace battlenet_api.Models.Warcraft
{
    public class BattlePetAbility
    {
        public int id { get; set; }
        public string name { get; set; }
        public string icon { get; set; }
        public int cooldown { get; set; }
        public int rounds { get; set; }
        public int petTypeId { get; set; }
        public bool isPassive { get; set; }
        public bool hideHints { get; set; }
    }
}
