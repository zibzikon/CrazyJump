using System.Collections.Generic;
using System.Linq;
using Foundation.Extensions;
using Kernel.Utils.Attributes;
using UnityEngine;
using Zenject;

namespace Kernel.Installers
{
    public class SceneInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            foreach (var injectable in GetInjectables()) Container.BindInstance(injectable);
        }

        private IEnumerable<Object> GetInjectables() 
            => FindObjectsOfType<MonoBehaviour>().Where(x => x.HaveCustomAttribute<ImplicitInjectableAttribute>());
    }
}