namespace Models.GameLogic.Models.Enums
{
    /// <summary>
    /// State of a game.
    /// </summary>
    internal enum GameState
    {
        /// <summary>
        /// Game is not running.
        /// </summary>
        Lobby = 0,

        /// <summary>
        /// A Game is currently in progress.
        /// </summary>
        Active = 2,

        /// <summary>
        /// A Game is in progress but paused.
        /// </summary>
        Paused = 3,

        /// <summary>
        /// A Game has endet and the results are beeing displayed.
        /// </summary>
        End = 4,
    }
}
