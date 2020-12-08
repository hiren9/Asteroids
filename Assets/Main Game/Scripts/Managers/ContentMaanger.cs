using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Asteroids.Gameplay;

namespace Asteroids.Managers
{
    public class ContentMaanger : MonoBehaviour
    {
        public List<Guns> guns = new List<Guns>();
        public List<Powers> powers = new List<Powers>();
        public List<Enemy> enemies = new List<Enemy>();
        public List<float> boosters = new List<float>();

        private static ContentMaanger instance;
        private void Awake()
        {
            if (instance == null)
            {
                instance = this;
            }
        }

        public static Guns GetGun(GunTypes gunType)
        {
            return instance.guns.Find(x => x.gunType == gunType);
        }

        public static Enemy GetEnemy(EnemyTypes enemyType)
        {
            return instance.enemies.Find(x => x.currEnemySpawnClass.enemyType == enemyType);
        }

        public static Powers GetPower(PowerTypes powerType)
        {
            return instance.powers.Find(x => x.powerType == powerType);
        }
        public static float GetBooster(int value)
        {
            return instance.boosters.Find(x => x == value);
        }

        public static List<Powers> GetAllPower()
        {
            return instance.powers;
        }

        public static List<Guns> GetAllGuns()
        {
            return instance.guns;
        }

        public static List<float> GetAllBooster()
        {
            return instance.boosters;
        }
    }

    
}