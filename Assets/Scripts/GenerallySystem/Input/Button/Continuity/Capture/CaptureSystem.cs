using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using GenerallySys.Definition;
using GenerallySys.Input.Button.Continuity.Data;
using GenerallySys.Input.Button.Utility;
using UnityEngine.Events;

namespace GenerallySys.Input.Button.Continuity.Capture {
    /// <summary>
    /// 入力検知を行うサブクラス
    /// </summary>
    public class CaptureSystem {
        private InputData _data;
        
        private List<A_Button> _buttons;
        
        public CaptureSystem(InputData data) {
            this._data = data;
            _buttons = _data.GetButtonsFromReference();
            
            _buttons[0].conditionChanged.AddListener(WasButtonPress);
        }

        private void WasButtonPress(ButtonCondition condition) {
            if (condition == ButtonCondition.Press) {
                WhatEvetInputCapture().Forget();
            }
        }

        private async UniTask WhatEvetInputCapture() {
            for (int i = 0; i < _buttons.Count; i++) {
                var wasInput = await  ButtonUtility.WaitForAnyCondition(
                    _buttons[i],
                    ButtonCondition.Press,
                    _data.intervals[i - 1]
                    );
                if (!wasInput) return;
            }
            _data.callback?.Invoke();
        }
    }
}