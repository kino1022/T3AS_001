using System;
using System.Collections.Generic;
using UnityEngine;

namespace Test.Input {
    [System.Serializable]
    public class MultiButtonInputData : ScriptableObject {
        /// <summary>
        /// “ü—Íƒ{ƒ^ƒ“‚Ì‡”Ô
        /// </summary>
        public List<A_Button> buttonsPattern;
        /// <summary>
        /// Še“ü—ÍŠÔ‚Ì“ü—Í—P—\
        /// </summary>
        public List<float> interval;
    }
}