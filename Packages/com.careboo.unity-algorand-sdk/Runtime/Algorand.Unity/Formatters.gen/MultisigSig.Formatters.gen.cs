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
    
    
    public partial struct MultisigSig
    {
        
        private static bool @__generated__IsValid = MultisigSig.@__generated__InitializeAlgoApiFormatters();
        
        private static bool @__generated__InitializeAlgoApiFormatters()
        {
            Algorand.Unity.AlgoApiFormatterLookup.Add<Algorand.Unity.MultisigSig>(new Algorand.Unity.AlgoApiObjectFormatter<Algorand.Unity.MultisigSig>(false).Assign("subsig", (Algorand.Unity.MultisigSig x) => x.Subsigs, (ref Algorand.Unity.MultisigSig x, Algorand.Unity.MultisigSig.Subsig[] value) => x.Subsigs = value, Algorand.Unity.ArrayComparer<Algorand.Unity.MultisigSig.Subsig>.Instance).Assign("thr", (Algorand.Unity.MultisigSig x) => x.Threshold, (ref Algorand.Unity.MultisigSig x, System.Byte value) => x.Threshold = value).Assign("v", (Algorand.Unity.MultisigSig x) => x.Version, (ref Algorand.Unity.MultisigSig x, System.Byte value) => x.Version = value));
            return true;
        }
        
        public partial struct Subsig
        {
            
            private static bool @__generated__IsValid = Subsig.@__generated__InitializeAlgoApiFormatters();
            
            private static bool @__generated__InitializeAlgoApiFormatters()
            {
                Algorand.Unity.AlgoApiFormatterLookup.Add<Algorand.Unity.MultisigSig.Subsig>(new Algorand.Unity.AlgoApiObjectFormatter<Algorand.Unity.MultisigSig.Subsig>(false).Assign("pk", (Algorand.Unity.MultisigSig.Subsig x) => x.PublicKey, (ref Algorand.Unity.MultisigSig.Subsig x, Algorand.Unity.Crypto.Ed25519.PublicKey value) => x.PublicKey = value).Assign("s", (Algorand.Unity.MultisigSig.Subsig x) => x.Sig, (ref Algorand.Unity.MultisigSig.Subsig x, Algorand.Unity.Sig value) => x.Sig = value));
                return true;
            }
        }
    }
}
