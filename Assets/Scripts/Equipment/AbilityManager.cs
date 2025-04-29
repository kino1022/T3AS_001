using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Equipment {
    public class AbilityManager : MonoBehaviour {
        /// <summary>
        /// 
        /// </summary>
        [SerializeField] private List<WeaponAbility.WeaponAbility> abilities;

        [SerializeField] private AbilitySlotManager slotManager;

        private void Start() {
            slotManager = GetComponent<AbilitySlotManager>();
        }

        /// <summary>
        /// スロットマネージャからスキルを取得する
        /// </summary>
        /// <returns></returns>
        private List<WeaponAbility.WeaponAbility> GetAbilitiesFromSlot() {
            return slotManager.slots.Select<AbilitySlot, WeaponAbility.WeaponAbility>(x => x.ability).ToList();
        }
    }
}