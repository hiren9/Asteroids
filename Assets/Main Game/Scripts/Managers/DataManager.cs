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

        public static float Booster
        {
            get { return PlayerPrefs.GetFloat(booster, 10); }
            set { PlayerPrefs.SetFloat(booster, value); }
        }




    }
}