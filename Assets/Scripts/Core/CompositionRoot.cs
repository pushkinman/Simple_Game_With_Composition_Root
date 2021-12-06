using Core;
using Core.Enum;
using Core.Input;
using Game.Interfaces;
using Interfaces;
using UnityEngine;

namespace Game.Core
{
    public class CompositionRoot : MonoBehaviour
    {
        private static IPlayer _player;
        private static IInputManager _inputManager;
        private static IResourcesManager _resourcesManager;
        private static IViewFactory _viewFactory;
        private static IUIRoot _uiRoot;

        public static IPlayer GetPlayer()
        {
            var resourcesManager = GetResourcesManager();
            return _player ??= resourcesManager.LoadResource<Player, EPlayers>(EPlayers.Player);
        }

        public static IInputManager GetInputManager()
        {
            return _inputManager ??= new InputManager();
        }
        
        public static IResourcesManager GetResourcesManager()
        {
            return _resourcesManager ??= GameObjectExtensions.CreateGameObjectWithComponent<ResourcesManager>();
        }
        
        public static IViewFactory GetViewFactory()
        {
            var uiRoot = GetUIRoot();
            return _viewFactory ??= new ViewFactory(_resourcesManager, uiRoot);
        }
        
        public static IUIRoot GetUIRoot()
        {
            var resourcesManager = GetResourcesManager();
            return _uiRoot ??= resourcesManager.LoadResource<UIRoot, EUIRoots>(EUIRoots.UIRoot);
        }
    }
}
