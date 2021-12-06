using Interfaces;
using UnityEngine;

namespace Core
{
    public class BaseWeapon : MonoBehaviour, IWeapon
    {
        private int _damage = 10;

        [SerializeField] private Transform bulletStartPosition;
        
        [SerializeField] private IBullet bullet;
        

        public void Shoot()
        {
            Instantiate((Object)bullet, bulletStartPosition.position, Quaternion.identity);
        }
    }
}