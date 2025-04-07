using System;
using UnityEngine.Events;

namespace Test.Item {
    [System.Serializable]
    /// <summary>
    /// 使用可能であるアイテムに対して適用されるA_ItemFeatures
    /// </summary>
    public class CanUseItem : A_ItemFeature {
        /// <summary>
        /// 使用された際に発火されるUnityEvent
        /// </summary>
        public UnityEvent wasUsed;
    }
}