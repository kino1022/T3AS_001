using UnityEngine;
using System;

namespace Test.Character.Mortion {
    [System.Serializable]
    [CreateAssetMenu(menuName = "CancelRute",fileName = "newCancelRute")]
    /// <summary>
    /// モーションのキャンセルルートを設定するクラス
    /// </summary>
    public class CancelRute : ScriptableObject {
        /// <summary>
        /// キャンセル判定が始まるフレーム
        /// </summary>
        public float startFrame;
        /// <summary>
        /// キャンセル判定が終了するフレーム
        /// </summary>
        public float endFrame;
        /// <summary>
        /// キャンセル成立で発生するモーション
        /// </summary>
        public A_Mortion cancelMortion;
    }
}