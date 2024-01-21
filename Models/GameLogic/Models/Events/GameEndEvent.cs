using Models.GameLogic.Models.Interfaces;

namespace Models.GameLogic.Models.Events
{
    /// <inheritdoc/>>
    internal class GameEndEvent : IGameEvent
    {
        /// <summary>
        /// Initialises a new instance of the <see cref="GameEndEvent"/> class.
        /// </summary>
        /// <param name="playersOrderdByWinningPlacement">List of <see cref="IPlayer"/>s. List is orderd by winning placements.</param>
        public GameEndEvent(List<IPlayer> playersOrderdByWinningPlacement)
        {
            this.PlayersOrderdByWinningPlacement = playersOrderdByWinningPlacement;
        }

        /// <inheritdoc/>>
        public string Name => "GameEnd";

        /// <summary>
        /// List of <see cref="IPlayer"/>s. List is orderd by winning placements.
        /// </summary>
        public List<IPlayer> PlayersOrderdByWinningPlacement { get; set; }
    }
}
