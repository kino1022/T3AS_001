using Element;
using UnityEngine;

namespace Equipment {
    /// <summary>
    /// 武器の持つ属性を管理するためのクラス
    /// </summary>
    [System.Serializable]
    public class WeaponElement {
        /// <summary>
        /// 付与する属性
        /// </summary>
        [SerializeReference] public AElement element;
        /// <summary>
        /// その属性の倍率
        /// </summary>
        public float elementRatio;
    }
}