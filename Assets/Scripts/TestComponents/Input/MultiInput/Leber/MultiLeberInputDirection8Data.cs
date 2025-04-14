using System;
using System.Collections.Generic;
using GenerallySys.Definition.Direction;
using UnityEngine;
using UnityEngine.Events;
using static GenerallySys.Definition.Direction.Direction8;

namespace Test.Input {
    [System.Serializable]
    [CreateAssetMenu(menuName = "Input/Multi/Leber/Direction8Data", fileName = "MultiLeberInputDirection8Data")]
    public class MultiLeberInputDirection8Data : ScriptableObject {
        /// <summary>
        /// 入力に要求する方向
        /// </summary>
        public List<Direction8> directions;
        /// <summary>
        /// 各入力間の入力猶予
        /// </summary>
        public List<float> intervals;
        /// <summary>
        /// 入力成功時に起こるイベント
        /// </summary>
        public UnityEvent couseEvent;
    }
}