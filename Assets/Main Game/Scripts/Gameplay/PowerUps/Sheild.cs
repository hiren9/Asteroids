using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Asteroids.Managers;

namespace Asteroids.Gameplay
{
    public class Sheild : Bullets
    {
        public Spaceship spaceship => ObjectReference.Spaceship;
        public override void BulletAnimation()
        {
            //throw new System.NotImplementedException();
        }

        public override void ExecuteBullet()
        {
            spaceship.isInvincible = true;
            gameObject.SetActive(true);            
            Destroy(gameObject, deathTime);
        }

        private void OnDestroy()
        {
            spaceship.isInvincible = false;
        }

        public override void OnBulletHIt()
        {
            //throw new System.NotImplementedException();
        }
        
    }
}