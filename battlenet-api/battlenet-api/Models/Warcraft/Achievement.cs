﻿using System.Collections.Generic;

namespace battlenet_api.Models.Warcraft
{
    public class Achievement
    {
        public int id { get; set; }
        public string title { get; set; }
        public int points { get; set; }
        public string description { get; set; }
        public string reward { get; set; }
        public List<RewardItem> rewardItems { get; set; }
        public string icon { get; set; }
        public List<Criterion> criteria { get; set; }
        public bool accountWide { get; set; }
        public int factionId { get; set; }
    }
}
