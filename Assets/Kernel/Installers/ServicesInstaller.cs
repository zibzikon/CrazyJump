using Kernel.StateMachine;
using Zenject;

namespace Kernel.Installers
{
    public class ServicesInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<IGameStateMachine>().To<GameStateMachine>().AsSingle();
        }
    }
}