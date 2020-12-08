using Asteroids.Managers;

namespace Asteroids.Gameplay
{
    public class SingleShotGuns : Guns
    {              
        public override void UseGun(Spaceship ship)
        {
            var b = Instantiate(bullet, ship.gunPoint.position, ship.transform.rotation , ObjectReference.BulletParent.transform);

            b.ExecuteBullet();
        }

      
    }
}