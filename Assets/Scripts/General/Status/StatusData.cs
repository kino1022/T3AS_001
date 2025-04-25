using UnityEngine;

namespace General.Status {
    [System.Serializable]
    [CreateAssetMenu(menuName = "General/Status/StatusData")]
    public class StatusData : ScriptableObject {
        /// <summary>
        /// ステータスの初期値
        /// </summary>
        public float initialValue;
        
        /// <summary>
        /// 参照された際にマイナスの値を返すことを許容するかどうか
        /// </summary>
        public bool allowMinusVlaue;
    }
}