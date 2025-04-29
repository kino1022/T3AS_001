using System;
using UnityEngine;

namespace WeaponAbility {
    [Serializable]
    public abstract class AbilityEffect {
        public virtual void OnExecute() {
            
        }

        public virtual void OnDisExecute() {
            
        }
    }
}