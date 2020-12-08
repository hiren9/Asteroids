using UnityEngine;

namespace Asteroids.Gameplay
{
    public abstract class Powers : MonoBehaviour
    {
        public PowerTypes powerType;
        public GameObject prefab;
        public abstract void UsePower(Spaceship ship);
    }

    public enum PowerTypes
    {
        BLAST,
        SHEILD
    }
}