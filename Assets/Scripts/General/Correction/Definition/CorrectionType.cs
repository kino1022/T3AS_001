namespace General.Correction.Definition {
    /// <summary>
    /// 補正値の計算のされ方を示す分類
    /// </summary>
    public enum CorrectionType {
        /// <summary>
        /// 固定値での補正値
        /// </summary>
        Fixed = 0,
        /// <summary>
        /// 割合での補正値
        /// </summary>
        Ratio = 1,
    }
}