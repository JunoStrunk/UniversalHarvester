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
    
    
    public partial struct EncryptedPayload
    {
        
        private static bool @__generated__IsValid = EncryptedPayload.@__generated__InitializeAlgoApiFormatters();
        
        private static bool @__generated__InitializeAlgoApiFormatters()
        {
            Algorand.Unity.AlgoApiFormatterLookup.Add<Algorand.Unity.WalletConnect.EncryptedPayload>(new Algorand.Unity.AlgoApiObjectFormatter<Algorand.Unity.WalletConnect.EncryptedPayload>(false).Assign("iv", (Algorand.Unity.WalletConnect.EncryptedPayload x) => x.Iv, (ref Algorand.Unity.WalletConnect.EncryptedPayload x, Algorand.Unity.Hex value) => x.Iv = value).Assign("hmac", (Algorand.Unity.WalletConnect.EncryptedPayload x) => x.Signature, (ref Algorand.Unity.WalletConnect.EncryptedPayload x, Algorand.Unity.Hex value) => x.Signature = value).Assign("data", (Algorand.Unity.WalletConnect.EncryptedPayload x) => x.Data, (ref Algorand.Unity.WalletConnect.EncryptedPayload x, Algorand.Unity.Hex value) => x.Data = value));
            return true;
        }
    }
}