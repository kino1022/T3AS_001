using System;
using System.Linq;
using Test.Input;
using UnityEngine;

namespace Reference {
    [System.Serializable]
    public class LeberReference {
        public GameObject target;
        public String typeName;

        public A_Leber GetLeber() {
            if (target == null || string.IsNullOrEmpty(typeName)) return null;
            return target.GetComponents<A_Leber>().FirstOrDefault(b => b.GetType().Name == typeName);
        }
    }
}