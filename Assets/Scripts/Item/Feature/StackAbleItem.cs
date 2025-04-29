using System;

namespace Item.Feature {
    [Serializable]
    public class StackAbleItem : AItemFeature {
        /// <summary>
        /// 最大スタック数
        /// </summary>
        public int maxStack;
    }
}