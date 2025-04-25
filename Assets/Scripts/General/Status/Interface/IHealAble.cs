namespace General.Status.Interface {
    /// <summary>
    /// 回復メソッドを持つクラスに対して与えられるインターフェース
    /// </summary>
    public interface IHealAble {
        public void Heal (float amount);
    }
}