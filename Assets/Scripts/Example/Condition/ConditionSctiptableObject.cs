using UnityEngine;

namespace Example.Condition {
    /// <summary>
    /// あらゆる条件判断に用いるScriptableObjectの基底クラス
    /// </summary>
    public abstract class ConditionSctiptableObject : ScriptableObject {
        /// <summary>
        /// 条件を満たしているかどうかを取得するメソッド
        /// </summary>
        /// <returns></returns>
        public virtual bool IsSatisfiled() {
            return false;
        }
    }
}