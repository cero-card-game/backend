using Models.GameLogic.Models.Interfaces;

namespace Models.GameLogic.Models.Events
{
    /// <inheritdoc/>
    internal class DrawnCardVoluntaryEvent : IGameEvent
    {
        /// <summary>
        /// Initialises a new instance of the <see cref="DrawnCardVoluntaryEvent"/> class.
        /// </summary>
        /// <param name="playerId">Id of the player that drew the card.</param>
        /// <param name="drawnCard">Insatnce of <see cref="ICard"/>.</param>
        public DrawnCardVoluntaryEvent(Guid playerId, ICard drawnCard)
        {
            this.PlayerId = playerId;
            this.DrawnCard = drawnCard;
        }

        /// <inheritdoc/>
        public string Name => "DrawnCardVoluntaryEvent";

        /// <summary>
        /// Id of the player that drew the card.
        /// </summary>
        public Guid PlayerId { get; set; }

        /// <summary>
        /// Card that the Player drew.
        /// </summary>
        public ICard DrawnCard { get; set; }
    }
}
