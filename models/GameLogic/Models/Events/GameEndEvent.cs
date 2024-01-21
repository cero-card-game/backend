using models.GameLogic.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace models.GameLogic.Models.Events
{
    internal class GameEndEvent : GameEvent
    {
        public GameEndEvent(List<Player> playersOrderdByWinningPlacement)
        {
            this.PlayersOrderdByWinningPlacement = playersOrderdByWinningPlacement;
        }

        public string Name => "GameEnd";

        public List<Player> PlayersOrderdByWinningPlacement { get; set; }
    }
}
