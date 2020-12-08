using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids.Gameplay 
{
    public class OnBulletHitCollider : MonoBehaviour
    {
        public Bullets bullets;
        private void OnTriggerEnter2D(Collider2D collision)
        {
            bullets.OnBulletHIt();

        }
    }
}