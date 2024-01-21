using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace models.GameLogic.Models.Enums
{
    internal enum GameState
    {
        Lobby = 0,
        Prepearation = 1,
        Active = 2,
        Paused = 3,
        End = 4,
    }
}
