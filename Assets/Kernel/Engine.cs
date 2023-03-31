using System;
using Kernel.ECS;
using Kernel.Systems.Registration;
using Sirenix.OdinInspector;
using UnityEngine;
using Zenject;

namespace Kernel
{
    public class Engine : MonoBehaviour
    {
        [Required, SerializeField] private EntityView _playerCharacter;
        
        private GameSystems _systems;
        private IGameEntityCreator _gameEntityCreator;

        [Inject]
        public void Construct(GameSystems systems, IGameEntityCreator gameEntityCreator)
        {
            _gameEntityCreator = gameEntityCreator;
            _systems = systems;
        }

        private void Awake()
        {
            _playerCharacter.Initialize(_gameEntityCreator.CreateEmpty());
        }

        private void Start()
        {
            _systems.Initialize();
        }

        private void Update()
        {
            _systems.Execute();
            _systems.Cleanup();
        }

        private void OnApplicationQuit()
        {
            _systems.TearDown();
        }
    }
}