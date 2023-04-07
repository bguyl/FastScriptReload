using UnityEngine;

namespace FastScriptReload.Tests.Runtime.Integration.CodePatterns
{
    public class MethodAccessingNestedEnum : MonoBehaviour 
    {
        internal enum NestedEnum
        {
            Value0 = 0,
            Value1 = 1,
            Value2 = 2
        }

        private NestedEnum _value = MethodAccessingNestedEnum.NestedEnum.Value0;   
        
        public void AssignNestedEnumToField()
        {
            _value = NestedEnum.Value1;
            //<confirmation-code>// _value = NestedEnum.Value2;
            //<confirmation-code>// TestDetourConfirmation.Confirm(this.GetType(), nameof(AssignNestedEnumToField), _value);
        }
    }
}