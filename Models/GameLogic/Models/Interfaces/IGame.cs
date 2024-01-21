using Models.GameLogic.Models.Enums;

namespace Models.GameLogic.Models.Interfaces
{
    /// <summary>
    /// Interface that represents a game.
    /// </summary>
    internal interface IGame
    {
        /// <summary>
        /// Identifier of the Game.
        /// </summary>
        public Guid Id { get; }

        /// <summary>
        /// Invitecode of the Game.
        /// </summary>
        public string InviteCode { get; }

        /// <summary>
        /// Playerlist of the Game.
        /// </summary>
        public List<IPlayer> PlayerList { get; }

        /// <summary>
        /// Rules for the Game.
        /// </summary>
        public GameRules Rules { get; set; }

        /// <summary>
        /// State of the Game.
        /// </summary>
        public GameState State { get; set; }
    }
}
