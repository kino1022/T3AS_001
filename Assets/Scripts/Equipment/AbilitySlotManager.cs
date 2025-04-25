using System.Collections.Generic;
using CustomAbility;
using UnityEngine;
using UnityEngine.Events;

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
        
        public UnityEvent slotChangeUEvent;

        public void SetNewSlot(WeaponAbility ability,bool isUnique = false) {
            if (slots.Count >= slotValue) {
                Debug.LogWarning($"アビリティスロットが一杯の状態でアビリティがセットされそうになりました");
                return;
            }
            var newSlot = new AbilitySlot();
            newSlot.ability = ability;
            newSlot.isUniqueSlot = isUnique;
            slots.Add(newSlot);
            slotChangeUEvent?.Invoke();
        }
        
        
        public void RemoveSlot(AbilitySlot slot) {
            slots.Remove(slot);
            slotChangeUEvent?.Invoke();
        }
        
        
    }
}