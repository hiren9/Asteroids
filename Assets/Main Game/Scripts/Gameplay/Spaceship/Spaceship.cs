using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Asteroids.Managers;

namespace Asteroids.Gameplay
{
    public class Spaceship : MonoBehaviour
    {
        public Transform gunPoint;
        public Transform powerPoint;
        public SpaceshipResources spaceshipResources;        

        private void Start()
        {
            spaceshipResources = new DefaultResources();

            var gun = ContentMaanger.GetGun((GunTypes)DataManager.Gun);
            var power = ContentMaanger.GetPower((PowerTypes)DataManager.Power);
            spaceshipResources.SetGun(gun);
            spaceshipResources.SetPower(power);
            spaceshipResources.SetSpaceShipReference(this);
            spaceshipResources.SetBooster(DataManager.Booster);
        }

        public void OnEnable()
        {
            RegisterEvents(true);
        }

        public void OnDisable()
        {
            RegisterEvents(false);
        }

        private void RegisterEvents(bool register)
        {
            if (register)
            {
                InputEvents.setSpaceShipTarget.AddListener(SetSpaceShipViewTarget);
                InputEvents.shoot.AddListener(Shoot);
                InputEvents.useBoost.AddListener(BoostRocket);
                InputEvents.usePower.AddListener(UsePower);
            }
            else
            {
                InputEvents.setSpaceShipTarget.RemoveListener(SetSpaceShipViewTarget);
                InputEvents.shoot.RemoveListener(Shoot);
                InputEvents.useBoost.RemoveListener(BoostRocket);
                InputEvents.usePower.RemoveListener(UsePower);
            }
        }   

        public void BoostRocket() 
        {
            transform.position += transform.up * (spaceshipResources.GetBoosterSpeed() * Time.deltaTime);
        }

        public void Shoot() 
        {
            spaceshipResources.Shoot();
        }

        public void UsePower() 
        {
            spaceshipResources.UsePower();
        }

        public void SetSpaceShipViewTarget(Vector3 position) 
        {
            transform.rotation = GetRotationFromPosition(spaceshipResources.SetSpaceShipViewTarget(position));
        }


        private Quaternion GetRotationFromPosition(Vector3 position)
        {
            var dir = position - transform.position;
            var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
            angle -= 90;
            return Quaternion.AngleAxis(angle, Vector3.forward);
        }

    }


}
