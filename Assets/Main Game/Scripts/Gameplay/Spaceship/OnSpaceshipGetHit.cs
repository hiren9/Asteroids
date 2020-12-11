using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids.Gameplay
{
    public class OnSpaceshipGetHit : MonoBehaviour
    {
        public Spaceship spaceship;

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.GetComponent<Enemy>() == null) return;

            spaceship.OnSpaceShipGotHit();
        }
    }
}