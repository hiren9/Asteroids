using UnityEngine;

namespace Asteroids.Gameplay
{
    public abstract class Powers : MonoBehaviour
    {
        public PowerTypes powerType;
        public Bullets power;
        public float timeBetWeen2Shots;

        private float currentshootTime = 0;
        public abstract void ExecutePower(Spaceship ship);

        public virtual void UsePower(Spaceship ship)
        {
            if(timeBetWeen2Shots <= 0)
            {
                ExecutePower(ship);
                return;
            }

            if (currentshootTime > 0) return;
            ExecutePower(ship);

            currentshootTime = timeBetWeen2Shots;
        }

        private void Update()
        {
            if (timeBetWeen2Shots <= 0) return;
            if (currentshootTime < 0) return;
            currentshootTime -= Time.deltaTime;
        }
    }

    public enum PowerTypes
    {
        BLAST,
        EIGHTWAY,
        SHEILD
    }
}