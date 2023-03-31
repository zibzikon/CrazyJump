using Kernel.Mediators;
using Sirenix.OdinInspector;
using Zenject;

namespace Kernel.Installers
{
    public class MainMenuInstaller : MonoInstaller
    {
        [Required, ShowInInspector] private IMainMediator _mainMediator;
        
        public override void InstallBindings()
        {
            Container.BindInstance(_mainMediator).AsSingle();
        }
    }
}