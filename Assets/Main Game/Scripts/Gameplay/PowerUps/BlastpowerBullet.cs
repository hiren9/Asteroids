using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids.Gameplay
{
    public class BlastpowerBullet : Bullets
    {
        public float moveSpeed = 10;
        private bool bulletAnimation = false;
        public GameObject bulletImage;

        private void Update()
        {
            if (!bulletAnimation) return;

            BulletAnimation();
        }

        public override void BulletAnimation()
        {
            transform.position += transform.up * moveSpeed * Time.deltaTime;
        }

        public override void ExecuteBullet()
        {
            bulletImage.SetActive(true);
            bulletAnimation = true;
            Destroy(gameObject, deathTime);
        }

        public override void OnBulletHIt()
        {
           // Destroy(gameObject);
        }
    }
}