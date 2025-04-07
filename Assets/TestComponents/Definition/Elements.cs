using System;
using UnityEngine;

namespace Test.Definition {
    /// <summary>
    /// 物理非物理全ての属性分類
    /// </summary>
    public enum Elements {
        /// <summary>
        /// 斬撃属性
        /// </summary>
        Slash,
        /// <summary>
        /// 打撃属性
        /// </summary>
        Blow,
        /// <summary>
        /// 刺突属性
        /// </summary>
        Pierting,
        /// <summary>
        /// 射撃属性
        /// </summary>
        Shot,
        Fire,
    }
    /// <summary>
    /// 物理ダメージの属性分類
    /// </summary>
    public enum PhysicalElement {
        /// <summary>
        /// 斬撃属性
        /// </summary>
        Slash = Elements.Slash,
        /// <summary>
        /// 打撃属性
        /// </summary>
        Blow = Elements.Blow,
        /// <summary>
        /// 刺突属性
        /// </summary>
        Pierting = Elements.Pierting,
        /// <summary>
        /// 射撃属性
        /// </summary>
        Shot = Elements.Shot,
    }
}