using System.Collections.Generic;
using UnityEngine;

namespace CustomAbility {
    [System.Serializable]
    [CreateAssetMenu(menuName = "Ability/WeaponAbility/Data")]
    public class AbilityData : ScriptableObject {
        
        /// <summary>
        /// アビリティの発動する条件
        /// </summary>
        [SerializeField] public ExecuteTerm term;
        
        /// <summary>
        /// 条件を満たした際に発動する効果のリスト
        /// </summary>
        [SerializeField] public List<AbilityEffect> effects;

        public AbilityData(ExecuteTerm term, List<AbilityEffect> effects) {
            this.term = term;
            this.effects = effects;
        }
    }
}