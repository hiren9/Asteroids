using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids.Gameplay
{
    public class EnemyCollider : MonoBehaviour
    {
        public Enemy enemy;
        private void OnTriggerEnter2D(Collider2D collision)
        {
            var b = collision.GetComponent<OnBulletHitCollider>();
            if (b != null)
            {
                enemy.OnGotHitByBullet(b.bullets);
            }

        }
    }
}