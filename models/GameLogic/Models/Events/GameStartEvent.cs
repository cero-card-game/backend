using models.GameLogic.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace models.GameLogic.Models.Events
{
    internal class GameStartEvent : GameEvent
    {
        public string Name => "GameStart";
    }
}
