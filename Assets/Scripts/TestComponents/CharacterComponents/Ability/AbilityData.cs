using Test.Character.Definition;
using UnityEditor.U2D;
using UnityEngine;

namespace Test.Character.Ability {
    [System.Serializable]
    [CreateAssetMenu(menuName = "アビリティデータ",fileName = "AbilityData")]
    public class AbilityData : ScriptableObject {
        /// <summary>
        /// アビリティの名前
        /// </summary>
        public string abilityName;
        /// <summary>
        /// アビリティの分類
        /// </summary>
        public AbilityType type;
    }
}