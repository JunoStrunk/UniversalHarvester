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
    
    
    public partial struct Wallet
    {
        
        private static bool @__generated__IsValid = Wallet.@__generated__InitializeAlgoApiFormatters();
        
        private static bool @__generated__InitializeAlgoApiFormatters()
        {
            Algorand.Unity.AlgoApiFormatterLookup.Add<Algorand.Unity.Kmd.Wallet>(new Algorand.Unity.AlgoApiObjectFormatter<Algorand.Unity.Kmd.Wallet>(false).Assign("driver_name", (Algorand.Unity.Kmd.Wallet x) => x.DriverName, (ref Algorand.Unity.Kmd.Wallet x, UnityCollections.FixedString64Bytes value) => x.DriverName = value).Assign("driver_version", (Algorand.Unity.Kmd.Wallet x) => x.DriverVersion, (ref Algorand.Unity.Kmd.Wallet x, System.UInt32 value) => x.DriverVersion = value).Assign("id", (Algorand.Unity.Kmd.Wallet x) => x.Id, (ref Algorand.Unity.Kmd.Wallet x, UnityCollections.FixedString128Bytes value) => x.Id = value).Assign("mnemonic_ux", (Algorand.Unity.Kmd.Wallet x) => x.MnemonicUx, (ref Algorand.Unity.Kmd.Wallet x, Algorand.Unity.Optional<System.Boolean> value) => x.MnemonicUx = value).Assign("name", (Algorand.Unity.Kmd.Wallet x) => x.Name, (ref Algorand.Unity.Kmd.Wallet x, UnityCollections.FixedString64Bytes value) => x.Name = value).Assign("supported_txs", (Algorand.Unity.Kmd.Wallet x) => x.SupportedTransactions, (ref Algorand.Unity.Kmd.Wallet x, Algorand.Unity.TransactionType[] value) => x.SupportedTransactions = value, Algorand.Unity.ArrayComparer<Algorand.Unity.TransactionType, Algorand.Unity.ByteEnumComparer<Algorand.Unity.TransactionType>>.Instance));
            return true;
        }
    }
}
