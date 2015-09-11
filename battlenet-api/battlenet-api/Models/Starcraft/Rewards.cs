using System.Collections.Generic;

namespace battlenet_api.Models.Starcraft
{
    public class Rewards
    {
        public List<Portrait> portraits { get; set; }
        public List<Decal> terranDecals { get; set; }
        public List<Decal> zergDecals { get; set; }
        public List<Decal> protossDecals { get; set; }
        public List<Skin> skins { get; set; }
        public List<Animation> animations { get; set; }
    }
}
