using System;
using Kernel.States;
using UnityEngine;
using Zenject;

namespace Kernel
{
    public class Bootstrap : MonoBehaviour
    {
        private IGameStateMachine _gameStateMachine;

        [Inject]
        public void Construct(IGameStateMachine gameStateMachine)
        {
            _gameStateMachine = gameStateMachine;
        }

        private void Start()
        {
            _gameStateMachine.ChangeState<MainMenuState>();
        }
    }
}