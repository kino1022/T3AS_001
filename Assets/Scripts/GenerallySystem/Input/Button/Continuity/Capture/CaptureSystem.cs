using System.Collections.Generic;
using GenerallySys.Input.Button.Continuity.Data;
using UnityEngine.Events;

namespace GenerallySys.Input.Button.Continuity.Capture {
    /// <summary>
    /// 入力検知を行うサブクラス
    /// </summary>
    public class CaptureSystem {
        private List<A_Button> _buttons;
        private List<float> _intervals;
        private UnityEvent _callback;
        
        public CaptureSystem(InputData data) {
            
        }

        private void WasButtonPress() {
            
        }
    }
}