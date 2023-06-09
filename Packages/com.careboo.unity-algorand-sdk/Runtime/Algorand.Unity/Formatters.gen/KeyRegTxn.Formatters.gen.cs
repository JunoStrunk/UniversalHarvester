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


namespace Algorand.Unity
{
    
    
    public partial struct KeyRegTxn
    {
        
        private static bool @__generated__IsValid = KeyRegTxn.@__generated__InitializeAlgoApiFormatters();
        
        private static bool @__generated__InitializeAlgoApiFormatters()
        {
            Algorand.Unity.AlgoApiFormatterLookup.Add<Algorand.Unity.KeyRegTxn>(new Algorand.Unity.AlgoApiObjectFormatter<Algorand.Unity.KeyRegTxn>(false).Assign("fee", (Algorand.Unity.KeyRegTxn x) => x.Fee, (ref Algorand.Unity.KeyRegTxn x, Algorand.Unity.MicroAlgos value) => x.Fee = value).Assign("fv", (Algorand.Unity.KeyRegTxn x) => x.FirstValidRound, (ref Algorand.Unity.KeyRegTxn x, System.UInt64 value) => x.FirstValidRound = value).Assign("gh", (Algorand.Unity.KeyRegTxn x) => x.GenesisHash, (ref Algorand.Unity.KeyRegTxn x, Algorand.Unity.GenesisHash value) => x.GenesisHash = value).Assign("lv", (Algorand.Unity.KeyRegTxn x) => x.LastValidRound, (ref Algorand.Unity.KeyRegTxn x, System.UInt64 value) => x.LastValidRound = value).Assign("snd", (Algorand.Unity.KeyRegTxn x) => x.Sender, (ref Algorand.Unity.KeyRegTxn x, Algorand.Unity.Address value) => x.Sender = value).Assign("type", (Algorand.Unity.KeyRegTxn x) => x.TransactionType, (ref Algorand.Unity.KeyRegTxn x, Algorand.Unity.TransactionType value) => x.TransactionType = value, Algorand.Unity.ByteEnumComparer<Algorand.Unity.TransactionType>.Instance).Assign("gen", (Algorand.Unity.KeyRegTxn x) => x.GenesisId, (ref Algorand.Unity.KeyRegTxn x, UnityCollections.FixedString32Bytes value) => x.GenesisId = value).Assign("grp", (Algorand.Unity.KeyRegTxn x) => x.Group, (ref Algorand.Unity.KeyRegTxn x, Algorand.Unity.TransactionId value) => x.Group = value).Assign("lx", (Algorand.Unity.KeyRegTxn x) => x.Lease, (ref Algorand.Unity.KeyRegTxn x, Algorand.Unity.TransactionId value) => x.Lease = value).Assign("note", (Algorand.Unity.KeyRegTxn x) => x.Note, (ref Algorand.Unity.KeyRegTxn x, System.Byte[] value) => x.Note = value, Algorand.Unity.ArrayComparer<System.Byte>.Instance).Assign("rekey", (Algorand.Unity.KeyRegTxn x) => x.RekeyTo, (ref Algorand.Unity.KeyRegTxn x, Algorand.Unity.Address value) => x.RekeyTo = value).Assign("votekey", (Algorand.Unity.KeyRegTxn x) => x.VoteParticipationKey, (ref Algorand.Unity.KeyRegTxn x, Algorand.Unity.ParticipationPublicKey value) => x.VoteParticipationKey = value).Assign("selkey", (Algorand.Unity.KeyRegTxn x) => x.SelectionParticipationKey, (ref Algorand.Unity.KeyRegTxn x, Algorand.Unity.VrfPubKey value) => x.SelectionParticipationKey = value).Assign("votefst", (Algorand.Unity.KeyRegTxn x) => x.VoteFirst, (ref Algorand.Unity.KeyRegTxn x, System.UInt64 value) => x.VoteFirst = value).Assign("votelst", (Algorand.Unity.KeyRegTxn x) => x.VoteLast, (ref Algorand.Unity.KeyRegTxn x, System.UInt64 value) => x.VoteLast = value).Assign("votekd", (Algorand.Unity.KeyRegTxn x) => x.VoteKeyDilution, (ref Algorand.Unity.KeyRegTxn x, System.UInt64 value) => x.VoteKeyDilution = value).Assign("nonpart", (Algorand.Unity.KeyRegTxn x) => x.NonParticipation, (ref Algorand.Unity.KeyRegTxn x, Algorand.Unity.Optional<System.Boolean> value) => x.NonParticipation = value));
            return true;
        }
        
        public partial struct Params
        {
            
            private static bool @__generated__IsValid = Params.@__generated__InitializeAlgoApiFormatters();
            
            private static bool @__generated__InitializeAlgoApiFormatters()
            {
                Algorand.Unity.AlgoApiFormatterLookup.Add<Algorand.Unity.KeyRegTxn.Params>(new Algorand.Unity.AlgoApiObjectFormatter<Algorand.Unity.KeyRegTxn.Params>(false).Assign("nonpart", (Algorand.Unity.KeyRegTxn.Params x) => x.NonParticipation, (ref Algorand.Unity.KeyRegTxn.Params x, Algorand.Unity.Optional<System.Boolean> value) => x.NonParticipation = value).Assign("votekey", (Algorand.Unity.KeyRegTxn.Params x) => x.VoteParticipationKey, (ref Algorand.Unity.KeyRegTxn.Params x, Algorand.Unity.ParticipationPublicKey value) => x.VoteParticipationKey = value).Assign("selkey", (Algorand.Unity.KeyRegTxn.Params x) => x.SelectionParticipationKey, (ref Algorand.Unity.KeyRegTxn.Params x, Algorand.Unity.VrfPubKey value) => x.SelectionParticipationKey = value).Assign("votefst", (Algorand.Unity.KeyRegTxn.Params x) => x.VoteFirst, (ref Algorand.Unity.KeyRegTxn.Params x, System.UInt64 value) => x.VoteFirst = value).Assign("votelst", (Algorand.Unity.KeyRegTxn.Params x) => x.VoteLast, (ref Algorand.Unity.KeyRegTxn.Params x, System.UInt64 value) => x.VoteLast = value).Assign("votekd", (Algorand.Unity.KeyRegTxn.Params x) => x.VoteKeyDilution, (ref Algorand.Unity.KeyRegTxn.Params x, System.UInt64 value) => x.VoteKeyDilution = value));
                return true;
            }
        }
    }
}
