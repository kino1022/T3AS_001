using Test.Character.Effect;
using UnityEngine;

namespace GenerallySys.CollectionManageSys.Test {
    public abstract class A_CollectionWithEffect : A_Collection {
        /// <summary>
        /// 存在を依存するA_Effect
        /// </summary>
        private A_Effect _effect;

        public A_CollectionWithEffect(A_Effect effect) {
            this._effect = effect;
            _effect.wasRelease += EffectWasReleased;
            
        }
        /// <summary>
        /// 生成時に読み込まれるメソッド
        /// </summary>
        protected virtual void WasConstructed() {
            
        }
        protected virtual void EffectWasReleased(A_Effect effect) {
            wasReleased?.Invoke(this);
        }
    }
}