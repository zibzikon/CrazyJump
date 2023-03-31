using UnityEngine;
using Zenject;

namespace Kernel.Installers
{
    public class BootstrapInstaller : MonoInstaller
    {
        [SerializeField] private Bootstrap _bootstrap;

        public override void InstallBindings()
        {
            Container.BindInstance(_bootstrap).AsSingle();
        }
    }
}