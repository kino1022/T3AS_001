using System;
using Element.Definition;
using UnityEngine;
using static UnityEngine.Object;

namespace Element {
    /// <summary>
    /// 属性の基底クラスとなるクラス
    /// </summary>
    [System.Serializable]
    public abstract class AElement {
        /// <summary>
        /// 属性の分類
        /// </summary>
        public ElementType type;
        /// <summary>
        /// 属性の名前
        /// </summary>
        public string elementName;
        /// <summary>
        /// ディスプレイで表示する際の名前表記
        /// </summary>
        public string displayName;
    }
}