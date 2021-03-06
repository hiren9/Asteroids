﻿using UnityEngine;

namespace Asteroids.Gameplay
{
    public class SpaceshipResources : ISpaceshipActions
    {
        public Spaceship spaceShip;        
        public float boosterSpeed;
        public float boosterFriction;
        public Powers power;
        public Guns gun;

        public void SetGun(Guns arg0)
        {
            gun = arg0;
        }

        public void SetPower(Powers arg0)
        {
            power = arg0;
        }

        public void SetBoosterAdFriction(float arg0 , float arg1)
        {
            boosterSpeed = arg0;
            boosterFriction = arg1;
        }

        public void SetSpaceShipReference(Spaceship arg0)
        {
            spaceShip = arg0;
        }

        public float GetBoosterSpeed()
        {
            return boosterSpeed;
        }

        public float GetBoosterFriction()
        {
            return boosterFriction;
        }

        public void BoostRocket()
        {
            Debug.LogError("Boost Rockets");
        }
        public Vector3 SetSpaceShipViewTarget(Vector3 position)
        {
            return position;
        }
        public void Shoot()
        {
            gun.UseGun(spaceShip);
        }
        public void UsePower()
        {
            power.UsePower(spaceShip);
        }
    }
}