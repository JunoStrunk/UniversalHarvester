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
    
    
    public partial struct DeleteMultisigRequest
    {
        
        private static bool @__generated__IsValid = DeleteMultisigRequest.@__generated__InitializeAlgoApiFormatters();
        
        private static bool @__generated__InitializeAlgoApiFormatters()
        {
            Algorand.Unity.AlgoApiFormatterLookup.Add<Algorand.Unity.Kmd.DeleteMultisigRequest>(new Algorand.Unity.AlgoApiObjectFormatter<Algorand.Unity.Kmd.DeleteMultisigRequest>(false).Assign("address", (Algorand.Unity.Kmd.DeleteMultisigRequest x) => x.Address, (ref Algorand.Unity.Kmd.DeleteMultisigRequest x, Algorand.Unity.Address value) => x.Address = value).Assign("wallet_handle_token", (Algorand.Unity.Kmd.DeleteMultisigRequest x) => x.WalletHandleToken, (ref Algorand.Unity.Kmd.DeleteMultisigRequest x, UnityCollections.FixedString128Bytes value) => x.WalletHandleToken = value).Assign("wallet_password", (Algorand.Unity.Kmd.DeleteMultisigRequest x) => x.WalletPassword, (ref Algorand.Unity.Kmd.DeleteMultisigRequest x, UnityCollections.FixedString128Bytes value) => x.WalletPassword = value));
            return true;
        }
    }
}
