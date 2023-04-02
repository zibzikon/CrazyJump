using UnityEngine;
using Zenject;

namespace Kernel.ECSIntegration
{
    [RequireComponent(typeof(EntityView))]
    public class SelfInitializedView : MonoBehaviour
    {
        private IGameEntityCreator _gameEntityCreator;

        [Inject]
        public void Construct(IGameEntityCreator gameEntityCreator)
        {
            _gameEntityCreator = gameEntityCreator;
        }
        
        private void Awake()
        {
           var view = GetComponent<EntityView>();

           view.Initialize(_gameEntityCreator.CreateEmpty());
        }
    }
}