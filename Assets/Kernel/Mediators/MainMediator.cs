using Kernel.StateMachine;
using Kernel.StateMachine.States;
using UnityEngine;
using Zenject;

namespace Kernel.Mediators
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