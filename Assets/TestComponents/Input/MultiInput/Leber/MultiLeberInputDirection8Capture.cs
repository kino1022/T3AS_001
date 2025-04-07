using System;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using GenerallySys.Definition.Direction;
using UnityEngine;

namespace Test.Input {
    public class MultiLeberInputDirection8Capture : MonoBehaviour {
        /// <summary>
        /// 連続入力のデータ
        /// </summary>
        [SerializeField] private List<MultiLeberInputDirection8Data> _data;
        /// <summary>
        /// 連続入力を検知するためのデータ
        /// </summary>
        private List<CaptureSystem> _capture;

        private void Start() {
            foreach (var data in _data) {
                _capture.Add(new CaptureSystem(data));
            }
        } 

        partial class CaptureSystem {
            private MultiLeberInputDirection8Data data;
            public CaptureSystem (MultiLeberInputDirection8Data data) {
                this.data = data;
                data.leber.changeDirection8.AddListener(LeberDirectionWasChanged);
            }

            private void LeberDirectionWasChanged (Direction8 direction) {
                if (data.directions[0] == direction) {

                }
            }

            private async UniTask MultiInputCapture () {
                Boolean succese = true;
                for (int i = 1; i < data.directions.Count; i ++ ) {
                    Boolean wasInput = await InputCapture(data.directions[i],data.intervals[i - 1]);
                    if(!wasInput) {
                        succese = false;
                        break;
                    }
                }
                if (succese) data.couseEvent?.Invoke();
            }

            private async UniTask<Boolean> InputCapture (Direction8 direction,float grace) {

                var tcs = new UniTaskCompletionSource();
                data.leber.changeDirection8.AddListener(OnTrigger);
                var completedTask = await UniTask.WhenAny(tcs.Task,UniTask.Delay(TimeSpan.FromSeconds(grace)));

                if (completedTask == 1) return true;
                else return false;

                void OnTrigger (Direction8 dir)  {
                    if (dir == direction) {
                        tcs.TrySetResult();
                        data.leber.changeDirection8.RemoveListener(OnTrigger);
                    }
                }
            }
        }
    }
}