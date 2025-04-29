using UnityEngine;

namespace Equipment {
    public class EquipmentData : ScriptableObject {
        /// <summary>
        /// 耐久値の最大値
        /// </summary>
        public float maxDurability;
        /// <summary>
        /// 初期の耐久値
        /// </summary>
        public float durability;
    }
}