using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Asteroids.Managers
{
    public class GameManager : MonoBehaviour
    {
        public static OnGameStart onGameStart = new OnGameStart();
        public static OnGameEnd onGameEnd = new OnGameEnd();
        public static AddToCurrentScore addToCurrentScore = new AddToCurrentScore();

        public static int currentScore;

        public int score;

        private static GameManager instance;


        private void Awake()
        {
            if (instance == null)
            {
                instance = this;
            }


        }

        private void OnGameStart()
        {
            currentScore = 0;
            score = 0;
        }

        private void OnGameEnd()
        {
            CheckAdSetHighScore();
        }

        private void CheckAdSetHighScore()
        {
            if (DataManager.HighScore >= currentScore) return;

            DataManager.HighScore = currentScore;
        }

        private void AddPoitsToCurrentScore(int points)
        {
            currentScore += points;
            score += points; 
        }

        private void Start()
        {
            GameSceneManager.LoadMainMenuScene();

            onGameStart.AddListener(OnGameStart);
            onGameEnd.AddListener(OnGameEnd);
            addToCurrentScore.AddListener(AddPoitsToCurrentScore);
        }

        public static void StartGame()
        {
            GameSceneManager.LoadEndlessScene();
            onGameStart.Invoke();
        }

    }

    public class OnGameStart : UnityEvent { }
    public class OnGameEnd : UnityEvent { }

    public class AddToCurrentScore : UnityEvent<int> { }

}