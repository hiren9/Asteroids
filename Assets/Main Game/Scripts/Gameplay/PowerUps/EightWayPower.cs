using Asteroids.Managers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids.Gameplay
{
    public class EightWayPower : Powers
    {
        public override void ExecutePower(Spaceship ship)
        {
            Vector3 angle = Vector3.zero;

            for (int i = 0; i < 8; i++)
            {
                var b = Instantiate(power, ship.gunPoint.position, Quaternion.Euler(ship.transform.eulerAngles + angle), ObjectReference.BulletParent.transform);

                b.ExecuteBullet();

                angle += Vector3.forward * 45f;
            }
        }        
       
    }
}
