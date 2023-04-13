namespace Kernel.ECSIntegration.Listeners
{
    public class DestroyableRegister : EntityRegisterBehaviour
    {
        public override void Register(GameEntity entity) => entity.isDestructable = true;
    }
}