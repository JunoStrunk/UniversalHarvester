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
    
    
    public partial struct NetworkMessage
    {
        
        private static bool @__generated__IsValid = NetworkMessage.@__generated__InitializeAlgoApiFormatters();
        
        private static bool @__generated__InitializeAlgoApiFormatters()
        {
            Algorand.Unity.AlgoApiFormatterLookup.Add<Algorand.Unity.WalletConnect.NetworkMessage>(new Algorand.Unity.AlgoApiObjectFormatter<Algorand.Unity.WalletConnect.NetworkMessage>(false).Assign("topic", (Algorand.Unity.WalletConnect.NetworkMessage x) => x.Topic, (ref Algorand.Unity.WalletConnect.NetworkMessage x, System.String value) => x.Topic = value, Algorand.Unity.StringComparer.Instance).Assign("type", (Algorand.Unity.WalletConnect.NetworkMessage x) => x.Type, (ref Algorand.Unity.WalletConnect.NetworkMessage x, System.String value) => x.Type = value, Algorand.Unity.StringComparer.Instance).Assign("payload", (Algorand.Unity.WalletConnect.NetworkMessage x) => x.Payload, (ref Algorand.Unity.WalletConnect.NetworkMessage x, System.String value) => x.Payload = value, Algorand.Unity.StringComparer.Instance).Assign("silent", (Algorand.Unity.WalletConnect.NetworkMessage x) => x.IsSilent, (ref Algorand.Unity.WalletConnect.NetworkMessage x, Algorand.Unity.Optional<System.Boolean> value) => x.IsSilent = value));
            return true;
        }
    }
}
