using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Asteroids.Managers;


namespace Asteroids.UI
{
    public class ShopView : MonoBehaviour
    {
        public List<Image> guns;
        public List<Image> powers;

        private void OnEnable()
        {
            SetSelectedData();
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

            if(guns.Count > DataManager.Gun )
            {
                guns[DataManager.Gun].color = Color.green;
            }

            if (powers.Count > DataManager.Power)
            {
                powers[DataManager.Power].color = Color.green;
            }
        }

        public void OnBackButton()
        {
            UIManager.ShowMainView();
            gameObject.SetActive(false);
        }

        public void OnSelectGun(int index)
        {
            DataManager.Gun = index;
            SetSelectedData();
        }

        public void OnSelectPower(int index)
        {
            DataManager.Power = index;
            SetSelectedData();
        }
    }
}