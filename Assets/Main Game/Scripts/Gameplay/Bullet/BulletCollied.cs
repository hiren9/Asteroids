using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids.Gameplay
{
    public class BulletCollied : MonoBehaviour
    {
        public Bullets bullets;
        private void OnTriggerEnter2D(Collider2D collision)
        {

            bullets.OnBulletHIt();
            //var a = collision.GetComponentInParent<Asteroid>();

            //Debug.LogError("HERE");
            //if (a != null)
            //{
            //    Debug.LogError("HERE 1");
            //    a.OnGotHitByBullet(bullets);
            //}

        }
    }
}