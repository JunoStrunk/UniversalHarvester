using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Algorand.Unity.Samples.WalletConnect
{
    public class menu_options : MonoBehaviour
    {
        public string wallet;
        public string credits;
        public GameObject wallet_canvas;
        public GameObject market_button;

        public void start_game()
        {
            Debug.Log("start button");
            Application.LoadLevel(wallet);
        }

        public void credits_scene()
        {
            Application.LoadLevel(credits);
        }

        public void exit_game()
        {
            Application.Quit();
        }

        public void enter_market()
        {
            wallet_canvas.SetActive(true);
        }
    }
}
