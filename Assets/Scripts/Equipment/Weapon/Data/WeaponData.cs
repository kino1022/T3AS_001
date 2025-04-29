using System.Collections.Generic;
using UnityEngine;

namespace Equipment.Weapon {
    /// <summary>
    /// 武器データの依存性注入用データ
    /// </summary>
    public class WeaponData : EquipmentData {
        /// <summary>
        /// 武器の攻撃力
        /// </summary>
        public float attackPoint;
        
        /// <summary>
        /// 武器の会心率
        /// </summary>
        public float criticalRate;
        
        /// <summary>
        /// 武器の持っている属性のリスト
        /// </summary>
        public List<WeaponElement> elements;
        
        /// <summary>
        /// 武器の持っているスロットのデータ
        /// </summary>
        public List<AbilitySlot> slots;
    }
}