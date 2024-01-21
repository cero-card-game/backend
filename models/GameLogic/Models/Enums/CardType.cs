using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace models.GameLogic.Models.Enums
{
    /// <summary>
    /// Enum which represents the type of a card
    /// </summary>
    internal enum CardType
    {
        /// <summary>
        /// represents a number card
        /// </summary>
        Number0 = 0,
        Number1 = 1,
        Number2 = 2,
        Number3 = 3,
        Number4 = 4,
        Number5 = 5,
        Number6 = 6,
        Number7 = 7,
        Number8 = 8,
        Number9 = 9,

        /// <summary>
        /// represents an action card in which the game events are interfered with
        /// </summary>
        Skip = 101,
        Reverse = 102,
        DrawTwo = 103,

        /// <summary>
        /// represents a colour change card
        /// </summary>
        ChangeColor = 201,
        ChnageColorDrawFour = 202,

        /// <summary>
        /// represents a card that is displayed concealed to the player
        /// </summary>
        Unknown = 999,
    
    }
}
