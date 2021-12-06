using System;

namespace Interfaces
{
    public interface IInputManager
    {
        IInputProviderInGame InputProviderInGame { get; set; }
        IInputProviderPause InputProviderPause { get; set; }

        void SetInGameInputActive();
        void SetPauseMenuInputActive();
    }
}