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
    
    
    public partial struct RenameWalletResponse
    {
        
        private static bool @__generated__IsValid = RenameWalletResponse.@__generated__InitializeAlgoApiFormatters();
        
        private static bool @__generated__InitializeAlgoApiFormatters()
        {
            Algorand.Unity.AlgoApiFormatterLookup.Add<Algorand.Unity.Kmd.RenameWalletResponse>(new Algorand.Unity.AlgoApiObjectFormatter<Algorand.Unity.Kmd.RenameWalletResponse>(false).Assign("error", (Algorand.Unity.Kmd.RenameWalletResponse x) => x.Error, (ref Algorand.Unity.Kmd.RenameWalletResponse x, Algorand.Unity.Optional<System.Boolean> value) => x.Error = value).Assign("message", (Algorand.Unity.Kmd.RenameWalletResponse x) => x.Message, (ref Algorand.Unity.Kmd.RenameWalletResponse x, System.String value) => x.Message = value, Algorand.Unity.StringComparer.Instance).Assign("wallet", (Algorand.Unity.Kmd.RenameWalletResponse x) => x.Wallet, (ref Algorand.Unity.Kmd.RenameWalletResponse x, Algorand.Unity.Kmd.Wallet value) => x.Wallet = value));
            return true;
        }
    }
}
