using Asteroids.Managers;
using UnityEngine;

namespace Asteroids.Gameplay
{
    public class SingleShotGuns : Guns
    {
        public float currentshootTime = 0;
        public override void UseGun(Spaceship ship)
        {            
            if (currentshootTime > 0) return; 
            
            var b = Instantiate(bullet, ship.gunPoint.position, ship.transform.rotation , ObjectReference.BulletParent.transform);

            b.ExecuteBullet();

            currentshootTime = timeBetWeen2Shots;
        }

        private void Update()
        {
            if (currentshootTime < 0) return;
            currentshootTime -= Time.deltaTime;            
        }

    }
}