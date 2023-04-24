using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Algorand.Unity.Samples.WalletConnect
{
    public class display : MonoBehaviour
    {
        public Text wallet_address;

        // Start is called before the first frame update
        void Start()
        {
            wallet_address.text = "Connected Account: " + WalletConnectManager.address;
        }

        // Update is called once per frame
        void Update()
        {
            wallet_address.text = "Connected Account: " + WalletConnectManager.address;
        }
    }
}
