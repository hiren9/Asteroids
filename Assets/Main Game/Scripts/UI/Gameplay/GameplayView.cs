using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Asteroids.Managers;

namespace Asteroids.UI
{
    public class GameplayView : MonoBehaviour
    {
        public void OnGameOver()
        {            
            GameSceneManager.LoadMainMenuScene();
            GameManager.onGameEnd.Invoke();
        }

        public void OnBackButton()
        {
            OnGameOver();
        }
    }
}