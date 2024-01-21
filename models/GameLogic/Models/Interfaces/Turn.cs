using models.GameLogic.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace models.GameLogic.Models.Interfaces
{
    internal interface Turn
    {
        public TurnType Type { get; set; }

        public Guid PlayerID { get; set; }
    }
}
