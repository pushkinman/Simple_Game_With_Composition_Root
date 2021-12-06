using System.Collections;
using System.Collections.Generic;
using Interfaces;
using UnityEngine;

public class Player : MonoBehaviour, IPlayer
{
    public IWeapon Weapon;
    
    public void Move(Vector3 vector)
    {
        transform.Translate(vector * Time.deltaTime);
    }

    public void FireWeapon()
    {
        Weapon.Shoot();
    }
}
