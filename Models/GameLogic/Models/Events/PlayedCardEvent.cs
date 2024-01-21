using Models.GameLogic.Models.Interfaces;

namespace Models.GameLogic.Models.Events
{
    /// <summary>
    /// Event used when a player played a card.
    /// </summary>
    internal class PlayedCardEvent : IGameEvent
    {
        /// <summary>
        /// Initialises a new instance of the <see cref="PlayedCardEvent"/> class.
        /// </summary>
        /// <param name="playerId">The Id of the Player that played the card.</param>
        /// <param name="playedCard">The <see cref="ICard"/> that the player played.</param>
        public PlayedCardEvent(Guid playerId, ICard playedCard)
        {
            this.PlayerId = playerId;
            this.PlayedCard = playedCard;
        }

        /// <inheritdoc/>
        public string Name => "PlayedCard";

        /// <summary>
        /// The Identifier of the Player that played the card.
        /// </summary>
        public Guid PlayerId { get; set; }

        /// <summary>
        /// The <see cref="ICard"/> that the player played.
        /// </summary>
        public ICard PlayedCard { get; set; }
    }
}
