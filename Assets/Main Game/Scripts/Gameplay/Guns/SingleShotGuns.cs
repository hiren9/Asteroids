using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids.Gameplay
{
    public class SingleShotGuns : Guns
    {              
        public override void UseGun(Spaceship ship)
        {
            var b = Instantiate(bullet, ship.gunPoint.position, ship.transform.rotation);

            b.ExecuteBullet();
        }

      
    }
}