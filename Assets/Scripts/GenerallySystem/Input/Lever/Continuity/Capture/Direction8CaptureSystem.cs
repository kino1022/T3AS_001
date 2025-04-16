using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using GenerallySys.Definition.Direction;
using GenerallySys.Utility;
using UnityEngine.Events;

namespace GenerallySys.Input.Lever.Continuity.Capture {
    public class Direction8CaptureSystem : A_CaptureSystem {
        private List<Direction8> _directions;

        public Direction8CaptureSystem(A_Lever lever,List<float> intervals,UnityEvent callback,List<Direction8> directions) 
            : base(lever, intervals, callback) {
            _directions = directions;
            Lever.posData.ChangeDirection8 += WasChangedDirection8;
        }

        private void WasChangedDirection8(Direction8 input) {
            if (_directions[0] == input) {
                WhatEverInput().Forget();
            }
        }

        private async UniTask WhatEverInput() {
            for (int i = 1; i < _directions.Count; i++) {
                var wasInput = await DirectionUtility.WaitForAnyDirectionInput(
                    Lever.posData.ChangeDirection8,
                     _directions[i],
                    Intervals[i - 1]
                    );
                
                if (!wasInput) return;
            }
            callback?.Invoke();
        }
    }
}