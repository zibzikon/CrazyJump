using Kernel.ECS;
using Kernel.Systems.Registration;
using Sirenix.OdinInspector;
using Zenject;

namespace Kernel.Installers
{
    public class GamePlayInstaller : MonoInstaller
    {
        [Required, ShowInInspector] private Engine _engine;
        
        public override void InstallBindings()
        {
            var contexts = Contexts.sharedInstance;

            Container.BindInstance(contexts);
            Container.BindInstance(contexts.game);
            Container.BindInstance(contexts.input);
            
            Container.Bind<IEntityIdentifierGenerator>().To<EntityIdentifierGenerator>().AsSingle();
            Container.Bind<IGameEntityCreator>().To<GameEntityCreator>().AsSingle();
            Container.Bind<GameSystems>().ToSelf().AsSingle();
            
            Container.BindInstance(_engine);
        }
        
    }
}