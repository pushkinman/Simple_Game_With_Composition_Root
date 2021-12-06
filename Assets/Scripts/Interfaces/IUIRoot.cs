using UnityEngine;

namespace Game.Interfaces
{
    public interface IUIRoot
    {
        public Transform CanvasMain { get; set; }
        public Transform CanvasOverlay { get; set; }
        void ShowCanvasOverlay();
        void HideCanvasOverlay();
    }
}