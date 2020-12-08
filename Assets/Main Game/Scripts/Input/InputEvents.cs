using UnityEngine;
using UnityEngine.Events;

namespace Asteroids.Gameplay
{
    public class InputEvents 
    {
        public static UseBoost useBoost = new UseBoost();
        public static SetSpaceShipViewTarget setSpaceShipTarget = new SetSpaceShipViewTarget();
        public static UsePowers usePower = new UsePowers();
        public static Shoot shoot = new Shoot();
    }

    public class UseBoost : UnityEvent { }

    public class SetSpaceShipViewTarget : UnityEvent<Vector3> { }

    public class UsePowers : UnityEvent { }

    public class Shoot : UnityEvent { }
}