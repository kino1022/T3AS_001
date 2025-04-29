using UnityEngine;

namespace WeaponAbility {
    [System.Serializable]
    public class WeaponAbility : ScriptableObject {
        
        /// <summary>
        /// 適用するアビリティデータ
        /// </summary>
        [SerializeField] public AbilityData data;
        
        protected virtual void OnSetUp() {
            data.term.SetUpTerm();
            AddEventListener();
        }
        protected virtual void OnRemove() {
            data.term.OnRemove();
            RemoveEventListener();
        }
        
        /// <summary>
        /// 発動イベントと解除イベントの購読を行うメソッド
        /// </summary>
        private void AddEventListener() {
            foreach (var effect in data.effects) {
                data.term.OnExecuteEvent += effect.OnExecute;
                data.term.OnDisExecuteEvent += effect.OnDisExecute;
            }
        }
        /// <summary>
        /// 発動イベントと解除イベントの購読解除を行うメソッド
        /// </summary>
        private void RemoveEventListener() {
            foreach (var effect in data.effects) {
                data.term.OnExecuteEvent -= effect.OnExecute;
                data.term.OnDisExecuteEvent -= effect.OnDisExecute;
            }
        }

        public void SetUpAbility() {
            OnSetUp();
        }
        
        public void RemoveAbility() {}
    }
}