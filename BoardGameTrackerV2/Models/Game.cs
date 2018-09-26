using System.ComponentModel;

namespace BoardGameTrackerV2.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public GameType Type { get; set; }
        [DisplayName("BoardGameGeek Identifier")]
        public int BggId { get; set; }

        public enum GameType
        {
            Mixed,
            Competitive,
            Cooperative
        }
    }
}
