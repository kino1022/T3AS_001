using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GenerallySys.Definition.Direction {
    /// <summary>
    /// 縦方向の二方向を抽象化したEnum
    /// </summary>
    public enum Direction2V {
        /// <summary>
        /// Neutral
        /// </summary>
        N2V,
        /// <summary>
        /// Front
        /// </summary>
        F2V,
        /// <summary>
        /// Back
        /// </summary>
        B2V,
    }
    /// <summary>
    /// 横方向の二方向を抽象化したEnum
    /// </summary>
    public enum Direction2H {
        /// <summary>
        /// Neutral
        /// </summary>
        N2H,
        /// <summary>
        /// Right
        /// </summary>
        R2H,
        /// <summary>
        /// Left
        /// </summary>
        L2H,
    }
    /// <summary>
    /// 四方向を抽象化したEnum
    /// </summary>
    public enum Direction4 {
        /// <summary>
        /// Neutral
        /// </summary>
        N4,
        /// <summary>
        /// Front
        /// </summary>
        F4,
        /// <summary>
        /// Right
        /// </summary>
        R4,
        /// <summary>
        /// Back
        /// </summary>
        B4,
        /// <summary>
        /// Left
        /// </summary>
        L4,
    }
    /// <summary>
    /// 八方向を抽象化したEnum
    /// </summary>
    public enum Direction8 {
        /// <summary>
        /// Neutral
        /// </summary>
        N8,
        /// <summary>
        /// Front
        /// </summary>
        F8,
        /// <summary>
        /// FrontAndRight
        /// </summary>
        FR8,
        /// <summary>
        /// Right
        /// </summary>
        R8,
        /// <summary>
        /// BackAndRight
        /// </summary>
        BR8,
        /// <summary>
        /// Back
        /// </summary>
        B8,
        /// <summary>
        /// BackAndLeft
        /// </summary>
        BL8,
        /// <summary>
        /// Left
        /// </summary>
        L8,
        /// <summary>
        /// FrontAndLeft
        /// </summary>
        FL8,
    }
}
