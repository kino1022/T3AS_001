using System;
using System.Collections.Generic;
using UnityEngine;

namespace Test.Input {
    [System.Serializable]
    public class MultiButtonInputData : ScriptableObject {
        /// <summary>
        /// ���̓{�^���̏���
        /// </summary>
        public List<A_Button> buttonsPattern;
        /// <summary>
        /// �e���͊Ԃ̓��͗P�\
        /// </summary>
        public List<float> interval;
    }
}