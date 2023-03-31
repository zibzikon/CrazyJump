namespace Kernel.ECS
{
    public interface IGameEventListener
    {
        void Register(GameEntity entity);
        void Unregister(GameEntity entity);
    }
}