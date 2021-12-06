using System.Collections.Generic;
using Game.Interfaces;
using UnityEngine;
using UnityEngine.UI;

namespace Game.Core.UI
{
    public class PauseMenu : MonoBehaviour, IPauseMenu
    {
        [SerializeField] private List<GameObject> buttons;

        private int _buttonIndex;

        private void Awake()
        {
            var inputManager = CompositionRoot.GetInputManager();
            inputManager.InputProviderPause.NextButton += ShowNextButton;
            inputManager.InputProviderPause.PreviousButton += ShowPreviousButton;
            
            SetButtonActiveByIndex(0);
        }

        public void ShowNextButton()
        {
            if (_buttonIndex == buttons.Count - 1)
            {
                _buttonIndex = 0;
            }
            else
            {
                _buttonIndex++;
            }

            SetButtonActiveByIndex(_buttonIndex);
        }

        public void ShowPreviousButton()
        {
            if (_buttonIndex == 0)
            {
                _buttonIndex = buttons.Count - 1;
            }
            else
            {
                _buttonIndex--;
            }
            
            SetButtonActiveByIndex(_buttonIndex);
        }

        public void SetActive(bool value)
        {
            gameObject.SetActive(value);
        }

        private void SetButtonActiveByIndex(int index)
        {
            foreach (var button in buttons)
            {
                button.gameObject.SetActive(false);
            }

            buttons[index].SetActive(true);
        }
    }
}