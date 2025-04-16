using System;
using System.Collections.Generic;
using UnityEngine;

namespace Test.Character.Mortion {
    [System.Serializable]
    /// <summary>
    /// モーションについての情報を記述するすべてのクラスの規定クラス
    /// </summary>
    public abstract class A_MortionData : ScriptableObject {
        /// <summary>
        /// モーション中にかかる詠唱時間への補正値
        /// </summary>
        public float castRate = 1.0f;
        /// <summary>
        /// モーションに与えられるキャンセルルートのリスト
        /// </summary>
        public List<CancelRute> cancelRutes;
        /// <summary>
        /// モーションに付随するエフェクトのリスト
        /// </summary>
        public List<MortionEffect> effects;
    }
}