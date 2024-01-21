using models.GameLogic.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace models.GameLogic.Models.Events
{
    internal class DrawnCardVoluntaryEvent : GameEvent
    {
        public DrawnCardVoluntaryEvent(Guid playerId, Card drawnCard)
        {
            this.PlayerId = playerId;
            this.DrawnCard = drawnCard;
        }

        public string Name => "DrawnCardVoluntaryEvent";

        public Guid PlayerId {  get; set; }

        public Card DrawnCard { get; set; }
    }
}
