using Models.GameLogic.Models.Interfaces;

namespace Models.GameLogic.Models.Events
{
    /// <inheritdoc/>>
    internal class GameStartEvent : IGameEvent
    {
        /// <inheritdoc/>>
        public string Name => "GameStart";
    }
}
