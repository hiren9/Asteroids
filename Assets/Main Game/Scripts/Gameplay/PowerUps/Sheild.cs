using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids.Gameplay
{
    public class Sheild : Bullets
    {
        public override void BulletAnimation()
        {
            //throw new System.NotImplementedException();
        }

        public override void ExecuteBullet()
        {
            gameObject.SetActive(true);            
            Destroy(gameObject, deathTime);
        }

        public override void OnBulletHIt()
        {
            //throw new System.NotImplementedException();
        }
        
    }
}