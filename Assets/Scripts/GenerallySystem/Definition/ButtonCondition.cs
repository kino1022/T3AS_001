using System;
using UnityEngine;

namespace GenerallySys.Definition {
    /// <summary>
    /// ボタンの押下状態を表現するEnum
    /// </summary>
    public enum ButtonCondition {
        /// <summary>
        /// 入力なし
        /// </summary>
        None = 0,
        /// <summary>
        /// 押下された
        /// </summary>
        Press = 1,
        /// <summary>
        /// 保持状態
        /// </summary>
        Hold = 2,
    }
}