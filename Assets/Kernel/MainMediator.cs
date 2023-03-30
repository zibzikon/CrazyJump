using Kernel;
using Kernel.States;
using UnityEngine;
using Zenject;

namespace Game
{
    public class MainMediator : MonoBehaviour, IMainMediator
    {
        private IGameStateMachine _gameStateMachine;

        [Inject]
        public void Construct(IGameStateMachine gameStateMachine)
        {
            _gameStateMachine = gameStateMachine;
        }
        
        public void PlayGame() => _gameStateMachine.ChangeState<PlayGameState>();
    }
}