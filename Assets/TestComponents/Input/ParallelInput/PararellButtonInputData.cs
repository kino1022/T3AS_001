using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Test.Input {
    /// <summary>
    /// ボタン同時入力の定義に使用するデータのクラス
    /// </summary>
    public class ParallelButtonInputData : ScriptableObject {
        /// <summary>
        /// 同時押しに要求されるボタン
        /// </summary>
        public List<A_Button> buttons;
        /// <summary>
        /// 入力ずれを許容する秒数(どんな人間であろうと真性同時入力は不可能だと結論)
        /// </summary>
        public float grace;
        /// <summary>
        /// 入力成功時に発火されるイベント
        /// </summary>
        public UnityEvent couseEvent;
    }
}