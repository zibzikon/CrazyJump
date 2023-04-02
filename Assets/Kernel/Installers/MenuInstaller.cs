using Kernel.Mediators;
using Sirenix.OdinInspector;
using Zenject;

namespace Kernel.Installers
{
    public class MenuInstaller : MonoInstaller
    {
        [Required, ShowInInspector] private IMediator _mediator;
        
        public override void InstallBindings()
        {
            Container.BindInstance(_mediator).AsSingle();
        }
    }
}