using System;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using GenerallySys.Definition;
using GenerallySys.Input.Button.Utility;
using UnityEngine.Events;

namespace GenerallySys.Input.Button.Parallel.Capture {
    public class CaptureSystem {
        private List<A_Button> _buttons;
        private float _grace;
        private UnityEvent _callback;

        private async UniTask WhatEverInputCapture(List<A_Button> checkButtons) {
            Boolean [] wasPressed = new Boolean[checkButtons.Count];
            while (true) {
                await UniTask.Delay(TimeSpan.FromSeconds(0.01f));
                
            }
        }
    }
}