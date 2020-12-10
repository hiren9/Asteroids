using Asteroids.Managers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids.Gameplay
{
    public class TripleShotGuns : Guns
    {

        private float currentshootTime = 0;
        public override void UseGun(Spaceship ship)
        {
            currentshootTime -= Time.deltaTime;

            if (currentshootTime > 0) return;

            Vector3 angle = Vector3.forward * -20;

            for (int i = 0; i < 3; i++)
            {
                var b = Instantiate(bullet, ship.gunPoint.position, Quaternion.Euler( ship.transform.eulerAngles + angle), ObjectReference.BulletParent.transform);

                b.ExecuteBullet();

                angle += Vector3.forward * 20;
            }

            currentshootTime = timeBetWeen2Shots;
            
        }
    }
}