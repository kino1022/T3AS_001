using System.Collections.Generic;
using CustomAbility;
using UnityEngine;

namespace Equipment {
    public class AbilityManager : MonoBehaviour {
        /// <summary>
        /// 
        /// </summary>
        [SerializeField] private List<WeaponAbility> abilities;

        [SerializeField] private AbilitySlotManager slotManager;

        private List<WeaponAbility> GetAbilitiesFromSlot() {
            return null;
        }
    }
}