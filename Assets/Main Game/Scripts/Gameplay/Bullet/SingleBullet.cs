using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids.Gameplay
{
    public class SingleBullet : Bullets
    {
        public float moveSpeed = 10;
        private bool bulletAnimation = false;
        
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
            bulletAnimation = true;
            Destroy(gameObject, deathTime);
        }

        public override void OnBulletHIt()
        {
            //throw new System.NotImplementedException();
        }
    }
}