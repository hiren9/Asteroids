using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids.Gameplay
{
    [System.Serializable]
    public class NextEnemySpawnClass 
    {
        public float enemyHealth;
        public EnemyTypes enemyType;
        public Vector2 enemySpawnCountRange;   
    }

    public enum EnemyTypes
    {
        BIG_CHUNK,
        MED_CHUNK,
        SMALL_CHUNK

    }
}