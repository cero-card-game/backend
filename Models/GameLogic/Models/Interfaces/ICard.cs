using Models.GameLogic.Models.Enums;

namespace Models.GameLogic.Models.Interfaces
{
    /// <summary>
    /// Interface representing a Playing card.
    /// </summary>
    internal interface ICard
    {
        /// <summary>
        /// Enum that represents the card value.
        /// </summary>
        public CardType Type { get; set; }

        /// <summary>
        /// Enum that represents the card color.
        /// </summary>
        public CardColour Color { get; set; }
    }
}
