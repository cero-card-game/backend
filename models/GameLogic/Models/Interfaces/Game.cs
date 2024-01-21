using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using models.GameLogic.Models.Enums;

namespace models.GameLogic.Models.Interfaces
{
    internal class Game
    {
        public Guid Id { get; }
        public string InviteCode { get; }
        public List<Player> PlayerList { get; }
        public GameRules Rules { get; set; }
        public GameState State { get; set; }
        public List<Turn> Turns { get; set; }

    }
}
