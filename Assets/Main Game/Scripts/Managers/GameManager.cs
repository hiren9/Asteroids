using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Asteroids.Managers
{
    public class GameManager : MonoBehaviour
    {
        public static OnGameStart onGameStart = new OnGameStart();


        private static GameManager instance;
        private void Awake()
        {
            if (instance == null)
            {
                instance = this;
            }
        }

        private void Start()
        {
            GameSceneManager.LoadMainMenuScene();
        }

        public static void StartGame()
        {
            GameSceneManager.LoadEndlessScene();
            onGameStart.Invoke();
        }

    }

    public class OnGameStart : UnityEvent { }

}