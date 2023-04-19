using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Algorand.Unity.Samples.WalletConnect
{
    public class menu_buttons : MonoBehaviour
    {
        public GameObject transaction_button;
        public string credits_level;
        public GameObject option_buttons;

        public void start_game()
        {
            option_buttons.SetActive(false);
            transaction_button.SetActive(true);
        }

        public void exit_game()
        {
            Application.Quit();
        }

        public void credits_scene()
        {
            Application.LoadLevel(credits_level);
        }
    }
}