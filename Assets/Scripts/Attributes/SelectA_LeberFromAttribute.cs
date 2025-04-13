using UnityEngine;

namespace Attributes {
    public class SelectA_LeberFromAttribute : PropertyAttribute {
        public string targetGameObjectField;

        public SelectA_LeberFromAttribute(string targetGameObjectField) {
            this.targetGameObjectField = targetGameObjectField;
        }
    }
}