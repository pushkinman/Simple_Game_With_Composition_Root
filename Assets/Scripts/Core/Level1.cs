using System;
using Game.Core;
using Game.Interfaces;
using Interfaces;
using UnityEngine;

namespace Core
{
    public class Level1 : MonoBehaviour
    {
        private IPlayer _player;
        private IInputManager _inputManager;
        private IViewFactory _viewFactory;

        private void Awake()
        {
            _player = CompositionRoot.GetPlayer();
            _inputManager = CompositionRoot.GetInputManager();
            _viewFactory = CompositionRoot.GetViewFactory();

            _inputManager.InputProviderInGame.PlayerMoved += _player.Move;
            _inputManager.InputProviderInGame.IsActive = true;
            _inputManager.InputProviderPause.IsActive = false;
            
            _viewFactory.CreatePauseMenu();
        }
    }
}
