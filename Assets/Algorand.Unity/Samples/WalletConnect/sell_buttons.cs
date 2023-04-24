using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Algorand.Unity.Samples.WalletConnect
{
    public class sell_buttons : MonoBehaviour
    {
        public GameObject wallet_connect;
        public GameObject sell_options;

        public void yes_option()
        {
            wallet_connect.SetActive(true);
            sell_options.SetActive(false);
        }

        public void no_option()
        {
            sell_options.SetActive(false);
        }

    }
}
