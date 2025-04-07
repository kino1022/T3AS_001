using System;
using System.Collections.Generic;
using UnityEngine;

namespace Test.Character.Mortion{
    /// <summary>
    /// モーションの特定フレームに付随する効果(スパアマ)とかを記述するクラス
    /// </summary>
    public class MortionEffect : ScriptableObject {
        /// <summary>
        /// エフェクトが発生し始めるフレーム
        /// </summary>
        public float startFrame;
        /// <summary>
        /// エフェクトが終了するフレーム
        /// </summary>
        public float endFrame;
    }
}