using System;
using System.Collections.Generic;
using System.Linq;
using CustomAbility;
using UnityEngine;

namespace Equipment {
    public class AbilityManager : MonoBehaviour {
        /// <summary>
        /// 
        /// </summary>
        [SerializeField] private List<WeaponAbility> abilities;

        [SerializeField] private AbilitySlotManager slotManager;

        private void Start() {
            slotManager = GetComponent<AbilitySlotManager>();
        }

        /// <summary>
        /// スロットマネージャからスキルを取得する
        /// </summary>
        /// <returns></returns>
        private List<WeaponAbility> GetAbilitiesFromSlot() {
            return slotManager.slots.Select(x => x.ability).ToList();
        }
    }
}