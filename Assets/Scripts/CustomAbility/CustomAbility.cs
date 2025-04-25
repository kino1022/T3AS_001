using UnityEngine;

namespace CustomAbility {
    [System.Serializable]
    public class CustomAbility {
        /// <summary>
        /// 適用するアビリティデータ
        /// </summary>
        [SerializeField] public CustomAbilityData abilityData;
    }
}