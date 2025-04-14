using System;
using UnityEngine.Events;

namespace Test.Item {
    /// <summary>
    /// 使用可能であるアイテムに対して適用されるA_ItemFeatures
    /// </summary>
    [System.Serializable]
    public class CanUseItem : A_ItemFeature {
        /// <summary>
        /// 使用された際に発火されるUnityEvent
        /// </summary>
        public UnityEvent wasUsed;
    }
}