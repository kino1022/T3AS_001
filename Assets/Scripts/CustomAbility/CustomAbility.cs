using System.Collections.Generic;
using UnityEngine;

namespace CustomAbility {
    [System.Serializable]
    [CreateAssetMenu(menuName = "Ability/CustomAbility")]
    public class CustomAbility : ScriptableObject {
        
        /// <summary>
        /// アビリティの発動する条件
        /// </summary>
        [SerializeField] private CustomExecuteTerm term;
        
        /// <summary>
        /// 条件を満たした際に発動する効果のリスト
        /// </summary>
        [SerializeField] private List<CustomEffect> effects;

        public CustomAbility(CustomExecuteTerm term, List<CustomEffect> effects) {
            this.term = term;
            this.effects = effects;
            SetUpAbility();
        }
        
        /// <summary>
        /// アビリティのシステムを
        /// </summary>
        public void SetUpAbility() {
            
        }
    }
}