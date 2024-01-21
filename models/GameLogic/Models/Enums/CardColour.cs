using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace models.GameLogic.Models.Enums
{
    /// <summary>
    /// Enum which represents the colour of a card
    /// </summary>
    internal enum CardColour
    {
        /// <summary>
        /// Colour for not revealed cards
        /// </summary>
        Unknown = 0,

        /// <summary>
        /// Colour for action-cards that dont have a colour
        /// </summary>
        None = 1,

        /// <summary>
        /// Colour for pink cards
        /// </summary>
        Pink = 2,

        /// <summary>
        /// Colour for blue cards
        /// </summary>
        Blue = 3,

        /// <summary>
        /// Colour for orange cards
        /// </summary>
        Orange = 4,

        /// <summary>
        /// Colour for green cards
        /// </summary>
        Green = 5
    }
}
