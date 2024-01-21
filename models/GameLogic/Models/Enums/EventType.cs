using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace models.GameLogic.Models.Enums
{
    internal enum EventType
    {
        //lobby events
        GameStart,
        GameEnd,

        //Events triggered by player
        PlayedCard,
        DrawnCardVoluntary,

        //Events for input awaition
        AwaitPlayerMove


    }
}
