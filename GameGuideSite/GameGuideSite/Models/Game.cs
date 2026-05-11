using System;

namespace GameGuideSite.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double Rating { get; set; }
        public int OnlinePlayers { get; set; }
        public string Lore { get; set; }
        public string LastUpdateSummary { get; set; }
        public string GuideLink { get; set; }
        public string ImageUrl { get; set; }

    }
}