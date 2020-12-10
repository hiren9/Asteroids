using UnityEngine;
using Asteroids.UI;

namespace Asteroids.Managers
{
    public class UIManager : MonoBehaviour
    {
        public ShopView shopView;
        public MainView mainView;

        private static UIManager instance;
        private void Awake()
        {
            if (instance == null)
            {
                instance = this;
            }
        }

        public static void ShowShopView()
        {
            instance.shopView.gameObject.SetActive(true);
        }

        public static void ShowMainView()
        {
            instance.mainView.gameObject.SetActive(true);
        }
    }
}