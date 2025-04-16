using System.Linq;
using UnityEngine;

namespace GenerallySys.Input.Lever.Reference {
    /// <summary>
    /// エディタからシーン上のレバーオブジェクトに参照するためのリファレンスクラス
    /// </summary>
    [System.Serializable]
    public class LeverReference {
        /// <summary>
        /// 対象のコンポーネントを持つゲームオブジェクト
        /// </summary>
        public GameObject target;
        /// <summary>
        /// コンポーネントの名前
        /// </summary>
        public string typeName;
        
        /// <summary>
        /// リファレンスで指定したA_Leverを返すメソッド
        /// </summary>
        /// <returns></returns>
        public A_Lever GetLever() {
            if (target == null || string.IsNullOrEmpty(typeName)) return null;
            return target.GetComponents<A_Lever>()
                .FirstOrDefault(l => l.GetType().Name == typeName);
        }
    }
}