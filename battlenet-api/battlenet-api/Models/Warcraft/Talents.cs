using System.Collections.Generic;

namespace battlenet_api.Models.Warcraft
{
    public class Talents
    {
        public bool selected { get; set; }
        public List<Talent> talents { get; set; }
        public Glyphs glyphs { get; set; }
        public Spec spec { get; set; }
        public string calcTalent { get; set; }
        public string calcGlyph { get; set; }
        public string calcSpec { get; set; }
    }
}
