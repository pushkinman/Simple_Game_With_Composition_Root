using System;
using Game.Interfaces;
using UnityEngine;

namespace Interfaces
{
    public interface IInputProviderInGame : IInputProvider
    {
        event Action<Vector3> PlayerMoved;
        event Action PauseMenuOpened;
        void CheckPlayerMoved();
        void CheckOpenPauseMenu();
    }
}