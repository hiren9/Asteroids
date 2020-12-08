
using UnityEngine;

namespace Asteroids.Gameplay
{
    public interface ISpaceshipActions
    {        
        void BoostRocket();
        void Shoot();
        void UsePower();
        Vector3 SetSpaceShipViewTarget(Vector3 position);
    }
}