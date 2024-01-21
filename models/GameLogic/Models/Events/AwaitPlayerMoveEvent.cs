using models.GameLogic.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace models.GameLogic.Models.Events
{
    internal class AwaitPlayerMoveEvent : GameEvent
    {
        public AwaitPlayerMoveEvent(Guid playerId)
        {
            this.PlayerId = playerId;
        }

        public string Name => "AwaitPlayerMoveEvent";

        public Guid PlayerId { get; set; }
    }
}
