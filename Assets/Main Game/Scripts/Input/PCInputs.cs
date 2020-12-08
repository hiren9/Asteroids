using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Asteroids.Gameplay
{
    public class PCInputs : Inputs
    {
        public override void CheckAndExecute()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                UsePower();
            }

            if (Input.GetKey(KeyCode.Mouse0))
            {
                Shoot();
            }

            if (Input.GetKey(KeyCode.Mouse1))
            {
                BoostRocket();
            }

            SetSpaceShipViewTarget();

        }

        public override void BoostRocket()
        {
            InputEvents.useBoost.Invoke();
        }

        public override void SetSpaceShipViewTarget()
        {
            var position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            position.z = 0;
            InputEvents.setSpaceShipTarget.Invoke(position);
        }

        public override void Shoot()
        {
            InputEvents.shoot.Invoke();
        }

        public override void UsePower()
        {
            InputEvents.usePower.Invoke();
        }
    }
}