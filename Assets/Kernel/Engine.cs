using Kernel.GamePlay.PlayerCharacter;
using Kernel.Systems.Registration;
using UnityEngine;
using Zenject;

namespace Kernel
{
    public class Engine : MonoBehaviour
    {
        [SerializeField] private PlayerCharacterConfiguration _playerCharacterConfiguration;
        
        private GameSystems _systems;
        
        private LevelContext _level;
        private GameContext _game;

        [Inject]
        public void Construct(GameSystems systems, LevelContext level, GameContext game)
        {
            _game = game;
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
            
            _level.generateNewLevelEntity.isCreatePlayerCharacter = true;
        }
        
        public void GenerateNewLevel()
        {
            _level.isGenerateNewLevel = true;
            _level.generateNewLevelEntity.AddLevelDifficulty(100);
            _level.generateNewLevelEntity.AddPlayerCharacterConfiguration(_playerCharacterConfiguration);
        }

        public void StartPlaying()
        {
            _game.isPlayingStarted = true;
        }
        
    }
}