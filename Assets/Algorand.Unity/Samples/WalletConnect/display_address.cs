using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Algorand.Unity.Samples.WalletConnect
{
    public class display_address : MonoBehaviour
    {
        public Text wallet_address;
        [SerializeField] private WalletConnectCanvas walletConnectCanvas;

        // Start is called before the first frame update
        void Start()
        {
            wallet_address.text = "Wallet Address:" + walletConnectCanvas.connectedAccount;
        }

        // Update is called once per frame
        void Update()
        {
            wallet_address.text = "Wallet Address:" + walletConnectCanvas.connectedAccount;
        }
    }
}
