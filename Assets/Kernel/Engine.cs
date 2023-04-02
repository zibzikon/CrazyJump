using Kernel.Systems.Registration;
using UnityEngine;
using Zenject;

namespace Kernel
{
    public class Engine : MonoBehaviour
    {
        private GameSystems _systems;
        
        private LevelContext _level;

        [Inject]
        public void Construct(GameSystems systems, LevelContext level)
        {
            _level = level;
            _systems = systems;
        }
        
        private void Start() => _systems.Initialize();

        private void Update()
        {
            _systems.Execute();
            _systems.Cleanup();
        }

        private void OnDestroy() => _systems.TearDown();

        public void BootstrapLevel()
        {
            GenerateNewLevel();
            _level.generateNewLevelEntity.AddLevelDifficulty(10);
        }
        
        public void GenerateNewLevel()
        {
            _level.isGenerateNewLevel = false;
            _level.isGenerateNewLevel = true;
        }

        public void StartPlaying()
        {
            
        }
        
    }
}