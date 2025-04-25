using System.Collections.Generic;
using UnityEngine;

namespace Equipment {
    /// <summary>
    /// 装備ごとのアビリティを管理する
    /// </summary>
    public class AbilitySlotManager : MonoBehaviour {
        /// <summary>
        /// この装備のスロットの最大数
        /// </summary>
        [SerializeField] private int slotValue = 5;
        /// <summary>
        /// この装備にセットされているアビリティ
        /// </summary>
        [SerializeField] public List<AbilitySlot> slots;
    }
}