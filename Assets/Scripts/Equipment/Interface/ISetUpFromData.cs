namespace Equipment.Interface {
    /// <summary>
    /// EquipmentDataからステータスの初期化を行える要素に対して課すインターフェース
    /// </summary>
    public interface ISetUpFromData {
        public void SetUpFromData(EquipmentData data) {}
    }
}