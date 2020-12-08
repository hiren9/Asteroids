using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Asteroids.Managers
{
    public class GameSceneManager : MonoBehaviour
    {
        public string endlessSceneName;
        public string mainMenuSceneName;

        private static GameSceneManager instance;
        private void Awake()
        {
            if (instance == null)
            {
                instance = this;
            }
        }

        public static void LoadEndlessScene()
        {
            instance.LoadScene(instance.endlessSceneName);
        }

        public static void LoadMainMenuScene()
        {
            instance.LoadScene(instance.mainMenuSceneName);
        }

        private void LoadScene(string sceneName)
        {
            SceneManager.LoadScene(sceneName);
        }


    }
}