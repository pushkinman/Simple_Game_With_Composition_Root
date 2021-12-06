using System;
using Game.Interfaces;
using UnityEngine;

namespace Interfaces
{
    public interface IInputProviderPause : IInputProvider
    {
        event Action NextButton;
        event Action PreviousButton;
        event Action PauseMenuClosed;
        void CheckNextButton();
        void CheckPreviousButton();
        void CheckClosePauseMenu();
    }
}