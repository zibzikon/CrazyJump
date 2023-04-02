using Kernel.Services;
using Zenject;

namespace Kernel.Installers
{
    public class ProjectInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<IInput>().To<UnityInput>().AsSingle();
            Container.Bind<ITime>().To<UnityTime>().AsSingle();
            Container.Bind<IResourcesLoader>().To<UnityResourceLoader>().AsSingle();
            Container.Bind<ISceneLoader>().To<UnitySceneLoader>().AsSingle();
            Container.Bind<IUnityViewService>().To<UnityViewService>().AsSingle();
        }
    }
}