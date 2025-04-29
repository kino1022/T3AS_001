using System.Collections.Generic;
using Attribute;
using UnityEngine;

namespace WeaponAbility {
    [System.Serializable]
    [CreateAssetMenu(menuName = "Ability/WeaponAbility/Data")]
    public class AbilityData : ScriptableObject {
        
        /// <summary>
        /// アビリティの発動する条件
        /// </summary>
        [SerializeReference,SelectableSerializeReference] 
        public ExecuteTerm term;
        
        /// <summary>
        /// 条件を満たした際に発動する効果のリスト
        /// </summary>
        [SerializeReference,SelectableSerializeReference] 
        public List<AbilityEffect> effects;

        public AbilityData(ExecuteTerm term, List<AbilityEffect> effects) {
            this.term = term;
            this.effects = effects;
        }
    }
}