using Asteroids.Managers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids.UI
{
    public class MainView : MonoBehaviour
    {
        public void OnPlay()
        {
            GameManager.StartGame();
        }
    }
}