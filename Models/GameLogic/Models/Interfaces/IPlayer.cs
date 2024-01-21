namespace Models.GameLogic.Models.Interfaces
{
    /// <summary>
    /// Interface representing a player of a game.
    /// </summary>
    internal interface IPlayer
    {
        /// <summary>
        /// Identifier of a player.
        /// </summary>
        public Guid Id { get; }

        /// <summary>
        /// Name of a player.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Carddeck of a player.
        /// </summary>
        public List<ICard> Cards { get; set; }
    }
}
