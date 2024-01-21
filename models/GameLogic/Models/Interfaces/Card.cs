using models.GameLogic.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace models.GameLogic.Models.Interfaces
{
    internal interface Card
    {
        public CardType Type { get; set; }

        public CardColour Color { get; set; }
    }
}
