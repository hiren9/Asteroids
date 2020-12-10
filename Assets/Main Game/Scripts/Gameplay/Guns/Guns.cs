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
        public float timeBetWeen2Shots;
        public abstract void UseGun(Spaceship ship);      
    }

    public enum GunTypes
    {
        SINGLESHOT,
        TRIPLESHOT
    }
}