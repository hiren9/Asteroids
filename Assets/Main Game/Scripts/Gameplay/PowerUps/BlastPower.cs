﻿using Asteroids.Managers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids.Gameplay
{
    public class BlastPower : Powers
    {   
        public override void ExecutePower(Spaceship ship)
        {
            var b = Instantiate(power, ship.gunPoint.position, ship.transform.rotation, ObjectReference.BulletParent.transform);
            b.ExecuteBullet();
        }
       
    }
}