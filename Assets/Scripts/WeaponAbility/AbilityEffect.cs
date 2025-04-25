using UnityEngine;

namespace CustomAbility {
    public class AbilityEffect : ScriptableObject {
    public virtual void OnExecute() { }

    public virtual void OnDisExecute() { }
    }
}