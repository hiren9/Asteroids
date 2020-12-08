using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids.Gameplay
{
    public class Asteroid : Enemy
    {
        public Vector2 forceRange;
        public Vector2 torqueRange;
        public override void StartAnimation()
        {
            rigidbody.AddForce(transform.up.normalized * Random.Range(forceRange.x, forceRange.y ) );
            rigidbody.AddTorque(Random.Range(torqueRange.x, torqueRange.y));
        }

    }

    
}