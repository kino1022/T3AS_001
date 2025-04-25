namespace General.Correction {
    /// <summary>
    /// 補正値計算を実行するクラスに課すインターフェース
    /// </summary>
    public interface ICorrectionExecuter {
        public float ExecuteCorrection (float value);
    }
}