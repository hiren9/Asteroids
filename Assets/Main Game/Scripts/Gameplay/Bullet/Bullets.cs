using UnityEngine;
using Asteroids.Managers;

namespace Asteroids.Gameplay
{
    [System.Serializable]
    public abstract class Bullets : MonoBehaviour
    {
        public float deathTime = 10;
        public float bulletDamage = 10;
        public abstract void ExecuteBullet();
        public abstract void BulletAnimation();
        public abstract void OnBulletHIt();
    }
}