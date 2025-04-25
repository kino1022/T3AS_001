namespace Equipment.Interface {
    /// <summary>
    /// 耐久値の回復が可能なクラスに対して課すインターフェース
    /// </summary>
    public interface IRepairAble {
        public void Repair(float amount);
    }
}