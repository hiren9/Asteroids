using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids.Gameplay
{
    public abstract class Inputs 
    {        
        public abstract void CheckAndExecute();

        public abstract void BoostRocket();

        public abstract void Shoot();

        public abstract void UsePower();

        public abstract void SetSpaceShipViewTarget();

    }
}