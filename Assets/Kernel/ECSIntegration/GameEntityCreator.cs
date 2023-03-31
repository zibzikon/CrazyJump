using Foundation.Extensions;

namespace Kernel.ECS
{
    public class GameEntityCreator : IGameEntityCreator
    {
        private readonly GameContext _gameContext;
        private readonly IEntityIdentifierGenerator _entityIdentifierGenerator;

        public GameEntityCreator(GameContext gameContext, IEntityIdentifierGenerator entityIdentifierGenerator)
        {
            _gameContext = gameContext;
            _entityIdentifierGenerator = entityIdentifierGenerator;
        }

        public GameEntity CreateEmpty() =>
            _gameContext.CreateEntity().With(x => x.AddID(_entityIdentifierGenerator.NextId()));
    }
}