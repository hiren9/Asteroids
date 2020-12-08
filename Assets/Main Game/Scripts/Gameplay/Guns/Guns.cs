using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Asteroids.Gameplay
{
    [System.Serializable]
    public abstract class Guns : MonoBehaviour
    {
        public Bullets bullet;
        public GunTypes gunType;       
        public abstract void UseGun(Spaceship ship);
        public void SetBullet(Bullets arg0)
        {
            bullet = arg0;
        }
    }

    public enum GunTypes
    {
        SINGLESHOT,
        MULTIPLESHOT
    }
}