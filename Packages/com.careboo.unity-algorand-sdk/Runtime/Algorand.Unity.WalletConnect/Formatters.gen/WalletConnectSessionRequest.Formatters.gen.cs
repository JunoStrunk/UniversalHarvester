//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using UnityCollections = Unity.Collections;


namespace Algorand.Unity.WalletConnect
{
    
    
    public partial struct WalletConnectSessionRequest
    {
        
        private static bool @__generated__IsValid = WalletConnectSessionRequest.@__generated__InitializeAlgoApiFormatters();
        
        private static bool @__generated__InitializeAlgoApiFormatters()
        {
            Algorand.Unity.AlgoApiFormatterLookup.Add<Algorand.Unity.WalletConnect.WalletConnectSessionRequest>(new Algorand.Unity.AlgoApiObjectFormatter<Algorand.Unity.WalletConnect.WalletConnectSessionRequest>(false).Assign("peerId", (Algorand.Unity.WalletConnect.WalletConnectSessionRequest x) => x.PeerId, (ref Algorand.Unity.WalletConnect.WalletConnectSessionRequest x, System.String value) => x.PeerId = value, Algorand.Unity.StringComparer.Instance).Assign("peerMeta", (Algorand.Unity.WalletConnect.WalletConnectSessionRequest x) => x.PeerMeta, (ref Algorand.Unity.WalletConnect.WalletConnectSessionRequest x, Algorand.Unity.WalletConnect.ClientMeta value) => x.PeerMeta = value).Assign("chainId", (Algorand.Unity.WalletConnect.WalletConnectSessionRequest x) => x.ChainId, (ref Algorand.Unity.WalletConnect.WalletConnectSessionRequest x, Algorand.Unity.Optional<System.Int32> value) => x.ChainId = value));
            return true;
        }
    }
}
