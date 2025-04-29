using System;
using Example.Condition;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Example.Condition.TemplateCondition {
    /// <summary>
    /// 確率に依存する条件
    /// </summary>
    [Serializable]
    public class Probability : ConditionSctiptableObject {
        
        /// <summary>
        /// 確率
        /// </summary>
        [SerializeField] public float probability;
        
        
        public override bool IsSatisfiled() {
            return Random.Range(0.0f,100.0f) > probability;
        }
    }
}