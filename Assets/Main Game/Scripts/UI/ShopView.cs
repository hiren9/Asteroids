using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Asteroids.Managers;


namespace Asteroids.UI
{
    public class ShopView : MonoBehaviour
    {
        public Text gunsInfoText;
        public Text powersInfoText;

        public List<Image> guns;        
        public List<string> gunsString;
        public List<Image> powers;
        public List<string> powersString;

        private void OnEnable()
        {
            SetSelectedData();
            SetPowerInfo();
            SetGunInfo();
        }

        private void SetSelectedData()
        {
            foreach (var item in guns)
            {
                item.color = Color.white;
            }

            foreach (var item in powers)
            {
                item.color = Color.white;
            }

            if (powers.Count > DataManager.Power)
            {
                powers[DataManager.Power].color = Color.green;
            }

            if (guns.Count > DataManager.Gun)
            {
                guns[DataManager.Gun].color = Color.green;
            }
        }

        public void OnBackButton()
        {
            UIManager.ShowMainView();
            gameObject.SetActive(false);
        }

        private void SetPowerInfo()
        {
            if (powers.Count > DataManager.Power)
            {
                powersInfoText.text = powersString[DataManager.Power];
            }
        }
        private void SetGunInfo()
        {
            if (guns.Count > DataManager.Gun)
            {
                gunsInfoText.text = gunsString[DataManager.Gun];
            }
        }

        public void OnSelectGun(int index)
        {
            DataManager.Gun = index;
            SetSelectedData();
            SetGunInfo();
        }

        public void OnSelectPower(int index)
        {
            DataManager.Power = index;
            SetSelectedData();
            SetPowerInfo();
        }
    }
}