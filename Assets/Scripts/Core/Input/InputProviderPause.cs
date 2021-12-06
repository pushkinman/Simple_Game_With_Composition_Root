using System;
using Interfaces;
using UnityEngine;

namespace Game.Core.Input
{
    public class InputProviderPause : MonoBehaviour, IInputProviderPause
    {
        
        public bool IsActive { get; set; }

        public event Action NextButton;
        public event Action PreviousButton;
        public event Action PauseMenuClosed;

        public void CheckNextButton()
        {
            if (UnityEngine.Input.GetKeyDown(KeyCode.UpArrow))
            {
                NextButton?.Invoke();
            }
        }

        public void CheckPreviousButton()
        {
            if (UnityEngine.Input.GetKeyDown(KeyCode.DownArrow))
            {
                PreviousButton?.Invoke();
            }
        }

        public void CheckClosePauseMenu()
        {
            if (UnityEngine.Input.GetKeyDown(KeyCode.Q))
            {
                PauseMenuClosed?.Invoke();
            }
        }


        public void Update()
        {
            if (!IsActive) return;
            
            CheckNextButton();
            CheckPreviousButton();
            CheckClosePauseMenu();
        }
    }
}