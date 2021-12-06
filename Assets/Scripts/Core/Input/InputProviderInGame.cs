using System;
using Interfaces;
using UnityEngine;

namespace Core.Input
{
    public class InputProviderInGame : MonoBehaviour, IInputProviderInGame
    {
        public bool IsActive { get; set; }
        
        public event Action<Vector3> PlayerMoved;
        public event Action PauseMenuOpened;

        public void CheckPlayerMoved()
        {
            var movX = UnityEngine.Input.GetAxis("Horizontal");
            var movZ = UnityEngine.Input.GetAxis("Vertical");
            var direction = new Vector3(movX, 0, movZ);
            if (direction.magnitude > 0)
            {
                PlayerMoved?.Invoke(direction);
            }
        }

        public void CheckOpenPauseMenu()
        {
            if (UnityEngine.Input.GetKeyDown(KeyCode.Escape))
            {
                PauseMenuOpened?.Invoke();
            }
        }
        
        public void Update()
        {
            if (!IsActive) return;
            
            CheckPlayerMoved();
            CheckOpenPauseMenu();
        }
    }
}
