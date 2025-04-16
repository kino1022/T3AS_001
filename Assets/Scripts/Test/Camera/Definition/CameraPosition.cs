namespace Test.Camera.Definition {
    /// <summary>
    /// カメラの撮る場所を示すEnum
    /// </summary>
    public enum CameraPosition {
        /// <summary>
        /// 主観
        /// </summary>
        Subjective = 0,
        /// <summary>
        /// 三人称
        /// </summary>
        ThirdPerson = 1,
        /// <summary>
        /// スクリプト制御
        /// </summary>
        Script = 2,
    }
}