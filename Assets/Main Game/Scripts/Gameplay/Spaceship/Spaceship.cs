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
        public float friction  = 10; 

        private float tempBoostValue;
        private Vector3 forwardDirection;

        private void Start()
        {
            spaceshipResources = new DefaultResources();

            var gun = Instantiate( ContentMaanger.GetGun((GunTypes)DataManager.Gun) , Vector3.zero , Quaternion.identity , transform);
            var power = Instantiate(ContentMaanger.GetPower((PowerTypes)DataManager.Power), Vector3.zero, Quaternion.identity, transform);
            spaceshipResources.SetGun(gun);
            spaceshipResources.SetPower(power);
            spaceshipResources.SetSpaceShipReference(this);
            spaceshipResources.SetBoosterAdFriction(ObjectReference.Booster , friction);
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
            forwardDirection = transform.up.normalized;
            tempBoostValue = spaceshipResources.GetBoosterSpeed();
            UpdatePosition();
        }

        private void ReduceBoosterGradually()
        {
            if (tempBoostValue <= 0) return;
            tempBoostValue -= Time.deltaTime;
            UpdatePosition();
        }

        private void UpdatePosition()
        {
            transform.position += forwardDirection * (tempBoostValue * Time.deltaTime);
        }

        private void Update()
        {
            ReduceBoosterGradually();
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
