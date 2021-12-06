using System;
using Game.Core.Input;
using Interfaces;
using UnityEngine;

namespace Core.Input
{
    public class InputManager : IInputManager
    {
        public IInputProviderInGame InputProviderInGame { get; set; }
        public IInputProviderPause InputProviderPause { get; set; }

        public InputManager()
        {
            InputProviderInGame = GameObjectExtensions.CreateGameObjectWithComponent<InputProviderInGame>();
            InputProviderPause = GameObjectExtensions.CreateGameObjectWithComponent<InputProviderPause>();

            InputProviderInGame.PauseMenuOpened += SetPauseMenuInputActive;
            InputProviderPause.PauseMenuClosed += SetInGameInputActive;

            InputProviderInGame.IsActive = true;
            InputProviderPause.IsActive = false;
        }

        public void SetInGameInputActive()
        {
            InputProviderInGame.IsActive = true;
            InputProviderPause.IsActive = false;
        }

        public void SetPauseMenuInputActive()
            {
                InputProviderInGame.IsActive = false;
                InputProviderPause.IsActive = true;
            }
        }
    }