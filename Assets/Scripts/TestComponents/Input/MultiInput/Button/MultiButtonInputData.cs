using System;
using System.Collections.Generic;
using Attributes;
using UnityEngine;
using UnityEngine.Events;

namespace Test.Input {
    [System.Serializable]
    [CreateAssetMenu(menuName = "Input/Multi/Button", fileName = "MultiButtonInputData")]
    public class MultiButtonInputData : ScriptableObject {
        /// <summary>
        /// 入力ボタンの順番
        /// </summary>
        public List<A_Button> buttonsPattern;
        /// <summary>
        /// 各入力間の入力猶予
        /// </summary>
        public List<float> interval;
        /// <summary>
        /// 入力成立時に発火するイベント
        /// </summary>
        public UnityEvent couseEvent;
    }
}