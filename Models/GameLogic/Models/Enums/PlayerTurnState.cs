namespace Models.GameLogic.Models.Enums
{
    /// <summary>
    /// State of the Turn of a player.
    /// </summary>
    internal enum PlayerTurnState
    {
        /// <summary>
        /// Beginning of a player turn. In this state, effects such as "Draw 2+" and similar are executed.
        /// </summary>
        Start,

        /// <summary>
        /// The player can place or draw a card.
        /// </summary>
        Active,

        /// <summary>
        /// End of a turn after a player has placed a card. In this state, other players can " intervene" or,
        /// in the case of an action card such as "change color", perform this action.
        /// If a card is interposed, the turn is directly in this mode.
        /// </summary>
        End,
    }
}
