using General.Status.Interface;
using UnityEngine;

namespace General.Status {
    /// <summary>
    /// ステータスの管理を行うクラス
    /// </summary>
    public class Status : MonoBehaviour, IHealAble,IDamageAble {
        /// <summary>
        /// ステータスの元々の値
        /// </summary>
        [SerializeField] public BaseValue baseValue;
        
        
        public void Heal (float amount) {}
        
        public void Damage (float amount) {}
    }
}