using System;
using UnityEngine;

namespace Test.Character.Definition{
    /// <summary>
    /// ダメージ分類
    /// </summary>
    public enum DamageType {
        /// <summary>
        /// 無分類
        /// </summary>
        None,
        /// <summary>
        /// 物理
        /// </summary>
        Physical,
        /// <summary>
        /// 魔法
        /// </summary>
        Magic,
    }
}