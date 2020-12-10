using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids.Managers
{
    public class DataManager : MonoBehaviour
    {
        private const string currentGun = "C_Gun";
        private const string currentPower = "C_Power";
        private const string booster = "Boost";
        private const string highScore = "HighScore";

        public static int Gun
        {
            get { return PlayerPrefs.GetInt(currentGun, 0); }
            set { PlayerPrefs.SetInt(currentGun, value); }
        }

        public static int Power
        {
            get { return PlayerPrefs.GetInt(currentPower, 0); }
            set { PlayerPrefs.SetInt(currentPower, value); }
        }

        public static float HighScore
        {
            get { return PlayerPrefs.GetFloat(highScore, 0); }
            set { PlayerPrefs.SetFloat(highScore, value); }
        }




    }
}