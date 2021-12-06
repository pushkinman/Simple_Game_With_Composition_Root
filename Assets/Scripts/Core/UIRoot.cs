using System;
using System.Collections;
using System.Collections.Generic;
using Core.Input;
using Game.Core;
using Game.Interfaces;
using Interfaces;
using UnityEngine;

namespace Game
{
    public class UIRoot : MonoBehaviour, IUIRoot
    {
        [SerializeField] private Transform canvasMain;
        [SerializeField] private Transform canvasOverlay;

        private IInputManager _inputManager;

        public Transform CanvasMain { get => canvasMain; set => canvasMain = value; }
        public Transform CanvasOverlay { get => canvasOverlay; set => canvasOverlay = value; }

        private void Awake()
        {
            _inputManager = CompositionRoot.GetInputManager();
            _inputManager.InputProviderInGame.PauseMenuOpened += ShowCanvasOverlay;
            _inputManager.InputProviderInGame.PauseMenuOpened += HideCanvasOverlay;

            HideCanvasOverlay();
        }

        public void ShowCanvasOverlay()
        {
            canvasOverlay.gameObject.SetActive(true);
            Debug.Log("Shown");
        }
        
        public void HideCanvasOverlay()
        {
            canvasOverlay.gameObject.SetActive(false);
            Debug.Log("Hidden");
        }
    }
}
