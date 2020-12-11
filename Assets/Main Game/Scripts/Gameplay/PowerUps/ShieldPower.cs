using Asteroids.Managers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids.Gameplay
{
    public class ShieldPower : Powers
    {
        public override void ExecutePower(Spaceship ship)
        {
            var b = Instantiate(power, ship.gunPoint.position, ship.transform.rotation, ship.transform);
            
            b.ExecuteBullet();
        }             
    }
}