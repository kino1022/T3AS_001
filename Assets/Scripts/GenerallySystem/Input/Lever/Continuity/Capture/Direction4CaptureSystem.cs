using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using GenerallySys.Definition.Direction;
using GenerallySys.Utility;
using UnityEngine.Events;

namespace GenerallySys.Input.Lever.Continuity.Capture {
    public class Direction4CaptureSystem : A_CaptureSystem {
        private List<Direction4> _directions;

        public Direction4CaptureSystem(A_Lever lever, List<Direction4> directions, List<float> intervals, UnityEvent callback)
            : base(lever, intervals, callback) {
            this._directions = directions;

            Lever.posData.ChangeDirection4 += WasChangedDirection4;
        }
        
        private void WasChangedDirection4(Direction4 input) {
            if (input == _directions[0]) {
                WhatEverCapture().Forget();
            }
        }

        private async UniTask WhatEverCapture() {
            for (int i = 1; i < _directions.Count; i++) {
                var wasInput = await DirectionUtility.WaitForAnyDirectionInput(
                    Lever.posData.ChangeDirection4,
                    _directions[i], 
                    Intervals[i - 1]
                    );
                if (!wasInput) return;
            }
            callback?.Invoke();
        }
    }
}