using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Algorand.Unity.Samples.WalletConnect
{
    public class menu_buttons : MonoBehaviour
    {
        public string level_name;
        public void start_game()
        {
            Application.LoadLevel(level_name);
        }

        public void exit_game()
        {
            Application.Quit();
        }
    }
}
