using models.GameLogic.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace models.GameLogic.Models.Events
{
    internal class PlayedCardEvent : GameEvent
    {

        public PlayedCardEvent(Guid playerId, Card playedCard)
        {
            this.PlayerId = playerId;
            this.PlayedCard = playedCard;
        }
        public string Name => "PlayedCard";

        public Guid PlayerId { get; set; }

        public Card PlayedCard { get; set; }
    }
}
