using Core.Enum;
using Game.Core.UI;
using Game.Interfaces;
using Interfaces;

namespace Game.Core
{
    public class ViewFactory : IViewFactory
    {
        private IResourcesManager _resourcesManager;
        private IUIRoot _uiRoot;

        public ViewFactory(IResourcesManager resourcesManager, IUIRoot uiRoot)
        {
            _resourcesManager = resourcesManager;
            _uiRoot = uiRoot;
        }
        
        public IPauseMenu CreatePauseMenu()
        {
            var pauseMenu = _resourcesManager.LoadResource<PauseMenu, EViews>(EViews.PauseMenu);
            pauseMenu.transform.SetParent(_uiRoot.CanvasOverlay);
            return pauseMenu;
        }
    }
}