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
    
    
    public partial struct WalletInfoResponse
    {
        
        private static bool @__generated__IsValid = WalletInfoResponse.@__generated__InitializeAlgoApiFormatters();
        
        private static bool @__generated__InitializeAlgoApiFormatters()
        {
            Algorand.Unity.AlgoApiFormatterLookup.Add<Algorand.Unity.Kmd.WalletInfoResponse>(new Algorand.Unity.AlgoApiObjectFormatter<Algorand.Unity.Kmd.WalletInfoResponse>(false).Assign("wallet_handle", (Algorand.Unity.Kmd.WalletInfoResponse x) => x.WalletHandle, (ref Algorand.Unity.Kmd.WalletInfoResponse x, Algorand.Unity.Kmd.WalletHandle value) => x.WalletHandle = value).Assign("error", (Algorand.Unity.Kmd.WalletInfoResponse x) => x.Error, (ref Algorand.Unity.Kmd.WalletInfoResponse x, Algorand.Unity.Optional<System.Boolean> value) => x.Error = value).Assign("message", (Algorand.Unity.Kmd.WalletInfoResponse x) => x.Message, (ref Algorand.Unity.Kmd.WalletInfoResponse x, System.String value) => x.Message = value, Algorand.Unity.StringComparer.Instance));
            return true;
        }
    }
}
