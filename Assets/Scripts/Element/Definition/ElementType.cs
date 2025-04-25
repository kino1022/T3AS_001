namespace Element.Definition {
    /// <summary>
    /// 属性の分類
    /// </summary>
    public enum ElementType {
        /// <summary>
        /// 無分類
        /// </summary>
        None = 0,
        /// <summary>
        /// 物理分類
        /// </summary>
        Physics = 1,
        /// <summary>
        /// 魔法属性
        /// </summary>
        Magic = 2,
        /// <summary>
        /// 状態異常属性
        /// </summary>
        Effect = 3,
    }
}