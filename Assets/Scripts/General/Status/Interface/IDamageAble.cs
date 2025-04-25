using UnityEngine;

namespace General.Status.Interface {
    /// <summary>
    /// ダメージを受けるクラスに与えられるインターフェース
    /// </summary>
    public interface IDamageAble {
        public void Damage (float damage);
    }
}