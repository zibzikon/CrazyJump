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
            _level.generateNewLevelEntity.AddLevelDifficulty(10);
            
            var createPlayerCharacterEntity = _game.CreateEntity();
            createPlayerCharacterEntity.isCreatePlayerCharacter = true;
            createPlayerCharacterEntity.AddPlayerCharacterConfiguration(_playerCharacterConfiguration);
        }
        
        public void GenerateNewLevel()
        {
            _level.isGenerateNewLevel = false;
            _level.isGenerateNewLevel = true;
        }

        public void StartPlaying()
        {
            _game.isPlayingStarted = false;
            _game.isPlayingStarted = true;
        }
        
    }
}