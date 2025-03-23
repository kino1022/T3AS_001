using System;
using System.Collections.Generic;
using UnityEngine;

namespace Test.Input {
    [System.Serializable]
    public class MultiButtonInputData : ScriptableObject {
        /// <summary>
        /// 入力ボタンの順番
        /// </summary>
        public List<A_Button> buttonsPattern;
        /// <summary>
        /// 各入力間の入力猶予
        /// </summary>
        public List<float> interval;
    }
}