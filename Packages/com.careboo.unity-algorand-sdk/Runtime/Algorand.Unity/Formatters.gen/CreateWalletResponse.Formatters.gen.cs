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
    
    
    public partial struct CreateWalletResponse
    {
        
        private static bool @__generated__IsValid = CreateWalletResponse.@__generated__InitializeAlgoApiFormatters();
        
        private static bool @__generated__InitializeAlgoApiFormatters()
        {
            Algorand.Unity.AlgoApiFormatterLookup.Add<Algorand.Unity.Kmd.CreateWalletResponse>(new Algorand.Unity.AlgoApiObjectFormatter<Algorand.Unity.Kmd.CreateWalletResponse>(false).Assign("error", (Algorand.Unity.Kmd.CreateWalletResponse x) => x.Error, (ref Algorand.Unity.Kmd.CreateWalletResponse x, Algorand.Unity.Optional<System.Boolean> value) => x.Error = value).Assign("message", (Algorand.Unity.Kmd.CreateWalletResponse x) => x.Message, (ref Algorand.Unity.Kmd.CreateWalletResponse x, System.String value) => x.Message = value, Algorand.Unity.StringComparer.Instance).Assign("wallet", (Algorand.Unity.Kmd.CreateWalletResponse x) => x.Wallet, (ref Algorand.Unity.Kmd.CreateWalletResponse x, Algorand.Unity.Kmd.Wallet value) => x.Wallet = value));
            return true;
        }
    }
}
