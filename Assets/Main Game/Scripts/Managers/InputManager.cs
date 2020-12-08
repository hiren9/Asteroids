using Asteroids.Gameplay;
using UnityEngine;

namespace Asteroids.Managers
{
    public class InputManager : MonoBehaviour
    {
        private Inputs currentInput;

        public void Awake()
        {
            currentInput = new PCInputs();
        }

        private void Update()
        {
            HandleInputs();
        }

        private void HandleInputs()
        {
            currentInput.CheckAndExecute();
        }
    }
}