namespace Models.GameLogic.Models.Enums
{
    /// <summary>
    /// Rules that influence the Game mechanics.
    /// </summary>
    [Flags]
    internal enum GameRules
    {
        /// <summary>
        /// Stacking Draw2 or Draw4 cards.
        /// </summary>
        StackPlusCards,

        /// <summary>
        /// Passing on the cards when a 0 is played. Swap cards with a player of choice when a 7 is played.
        /// </summary>
        SwapOn7PassOn0,

        /// <summary>
        /// Place the card in between if you have the same card in your hand as the card played.
        /// </summary>
        InterceptAndInsert,

        /// <summary>
        /// Drawn cards must be played if it is playable.
        /// </summary>
        ForcedPlayOnDraw,

        /// <summary>
        /// Disable the ability to bluff of Draw4 cards.
        /// </summary>
        NoBluffingOnPlus4,

        /// <summary>
        /// Drawing must be continued until a playable card has been drawn.
        /// </summary>
        DrawUntilMatch,
    }
}
