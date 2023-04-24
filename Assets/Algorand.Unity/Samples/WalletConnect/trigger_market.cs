using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Algorand.Unity.Samples.WalletConnect
{
    public class trigger_market : MonoBehaviour
    {
        public GameObject sell_option;

        void OnTriggerEnter(Collider collider)
        {
            if (collider.tag == "market")
            {
                sell_option.SetActive(true);
            }
        }

        void OnTriggerExit(Collider collider)
        {
            if (collider.tag == "market")
            {
                sell_option.SetActive(false);
            }
        }

    }
}
