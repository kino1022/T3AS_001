namespace General.Status.Interface {
    public interface ISetUpStatusFromData {
        /// <summary>
        /// ステータスデータを元にステータスの初期化を行うメソッド
        /// </summary>
        /// <param name="statusData"></param>
        public void SetUpStatusFromData (StatusData statusData);
    }
}