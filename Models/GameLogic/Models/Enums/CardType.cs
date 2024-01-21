namespace Models.GameLogic.Models.Enums
{
    /// <summary>
    /// Enum which represents the type of a card.
    /// </summary>
    internal enum CardType
    {
        /// <summary>
        /// represents the number card 0.
        /// </summary>
        Number0 = 0,

        /// <summary>
        /// represents the number card 1.
        /// </summary>
        Number1 = 1,

        /// <summary>
        /// represents the number card 2.
        /// </summary>
        Number2 = 2,

        /// <summary>
        /// represents the number card 3.
        /// </summary>
        Number3 = 3,

        /// <summary>
        /// represents the number card 4.
        /// </summary>
        Number4 = 4,

        /// <summary>
        /// represents the number card 5.
        /// </summary>
        Number5 = 5,

        /// <summary>
        /// represents the number card 6.
        /// </summary>
        Number6 = 6,

        /// <summary>
        /// represents the number card 7.
        /// </summary>
        Number7 = 7,

        /// <summary>
        /// represents the number card 8.
        /// </summary>
        Number8 = 8,

        /// <summary>
        /// represents the number card 9.
        /// </summary>
        Number9 = 9,

        /// <summary>
        /// represents the skip-player card.
        /// </summary>
        Skip = 101,

        /// <summary>
        /// represents the reverse player order card.
        /// </summary>
        Reverse = 102,

        /// <summary>
        /// represents the draw two card.
        /// </summary>
        DrawTwo = 103,

        /// <summary>
        /// represents the colour change card.
        /// </summary>
        ChangeColor = 201,

        /// <summary>
        /// represents the colour change and draw four card.
        /// </summary>
        ChnageColorDrawFour = 202,

        /// <summary>
        /// represents a card that is displayed concealed to the player.
        /// </summary>
        Unknown = 999,
    }
}
