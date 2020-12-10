using Asteroids.Managers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Asteroids.UI
{
    public class MainView : MonoBehaviour
    {
        public Text highScore;

        private void Start()
        {            
            highScore.text = DataManager.HighScore.ToString();
        }
        public void OnPlay()
        {
            GameManager.StartGame();
        }

        public void ShowShopView()
        {
            UIManager.ShowShopView();
            gameObject.SetActive(false);
        }

        
    }
}