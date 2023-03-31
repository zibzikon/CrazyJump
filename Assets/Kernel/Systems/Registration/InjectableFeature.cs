using Entitas;
using Zenject;

namespace Kernel.Systems.Registration
{
    public class InjectableFeature : Feature
    {
        private readonly DiContainer _container;

        public InjectableFeature(DiContainer container)
        {
            _container = container;
        }

        public ISystem AddInjected<T>() where T : ISystem => Add(_container.Instantiate<T>());
    }
}