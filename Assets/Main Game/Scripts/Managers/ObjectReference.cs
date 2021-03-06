﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Asteroids.Gameplay;

namespace Asteroids.Managers
{
    public class ObjectReference : MonoBehaviour
    {
        public Spaceship _spaceship;
        public GameObject _bulletParent;
        public GameObject _enemyParent;

        public float _boosterValue;
        public float _boosterFrictionValue;


        public static float spawnRadius = 15;
        public static Vector2 AsteroidTargetRange = new Vector2(5 , 5);


        public static Spaceship Spaceship => instance._spaceship;
        public static GameObject BulletParent => instance._bulletParent;
        public static GameObject EnemeyParent => instance._enemyParent;

        public static float Booster => instance._boosterValue;
        public static float BoosterFriction => instance._boosterFrictionValue;

        private static ObjectReference instance;
        private void Awake()
        {
            if (instance == null)
            {
                instance = this;
            }
        }
    }
}