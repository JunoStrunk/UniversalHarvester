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


namespace Algorand.Unity.Kmd
{
    
    
    public partial struct RenewWalletHandleTokenRequest
    {
        
        private static bool @__generated__IsValid = RenewWalletHandleTokenRequest.@__generated__InitializeAlgoApiFormatters();
        
        private static bool @__generated__InitializeAlgoApiFormatters()
        {
            Algorand.Unity.AlgoApiFormatterLookup.Add<Algorand.Unity.Kmd.RenewWalletHandleTokenRequest>(new Algorand.Unity.AlgoApiObjectFormatter<Algorand.Unity.Kmd.RenewWalletHandleTokenRequest>(false).Assign("wallet_handle_token", (Algorand.Unity.Kmd.RenewWalletHandleTokenRequest x) => x.WalletHandleToken, (ref Algorand.Unity.Kmd.RenewWalletHandleTokenRequest x, UnityCollections.FixedString128Bytes value) => x.WalletHandleToken = value));
            return true;
        }
    }
}
