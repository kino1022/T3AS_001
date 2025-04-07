using System;
using System.Collections.Generic;
using GenerallySys.Definition.Direction;
using UnityEngine;
using UnityEngine.Events;

namespace Test.Input {
    [System.Serializable]
    /// <summary>
    /// Direction4形式での連続入力コマンドと成立時に発火するイベントを記録するクラス
    /// </summary>
    public class MultiLeberInputDirection4Data : ScriptableObject {
        /// <summary>
        /// 入力検知するレバー
        /// </summary>
        public A_Leber leber;
        /// <summary>
        /// 各入力で要求する方向
        /// </summary>
        public List<Direction4> directions;
        /// <summary>
        /// 各入力間の入力猶予
        /// </summary>
        public List<float> intervals;
        /// <summary>
        /// 入力成立時に発生するイベント
        /// </summary>
        public UnityEvent couseEvent;
    }
}