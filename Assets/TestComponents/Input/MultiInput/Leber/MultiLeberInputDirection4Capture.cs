using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Cysharp.Threading.Tasks;
using GenerallySys.Definition.Direction;
using UnityEngine;

namespace Test.Input {
    /// <summary>
    /// Direction4形式での特定方向連続入力を検知するための管理クラス
    /// </summary>
    public class MultiLeberInputDirection4Capture : MonoBehaviour {
        /// <summary>
        /// 入力判定対象のデータ
        /// </summary>
        [SerializeField] private List<MultiLeberInputDirection4Data> _datas;
        /// <summary>
        /// 入力判定クラスのリスト
        /// </summary>
        private List<CaptureSystem> _capture;

        private void Start() {
            for (int i = 0; i < _datas.Count; i ++) {
                _capture.Add(new CaptureSystem(_datas[i]));
            }
        }

        partial class CaptureSystem {
            public MultiLeberInputDirection4Data data;

            public CaptureSystem (MultiLeberInputDirection4Data data) {
                this.data = data;

                data.leber.changeDirection4.AddListener(LeberDirectionWasChanged);
            }

            private void LeberDirectionWasChanged (Direction4 direction) {
                if (data.directions[0] == direction) {
                    MultiInputCapture().Forget();
                }
            }

            private async UniTask MultiInputCapture () {
                Boolean succese = true;
                for (int i = 1; i < data.directions.Count; i++ ) {
                    Boolean wasInput = await InputCapture(data.directions[i],data.intervals[i - 1]);
                    if (!wasInput) {
                        succese = false;
                        break;
                    }
                }
                if (succese) data.couseEvent?.Invoke();
            }

            private async UniTask<Boolean> InputCapture (Direction4 direction,float grace) {
                var tcs = new UniTaskCompletionSource();
                data.leber.changeDirection4.AddListener(OnTrigger);

                var completedTask = await UniTask.WhenAny(tcs.Task,UniTask.Delay(TimeSpan.FromSeconds(grace)));

                if (completedTask == 1) return true;
                else return false;

                void OnTrigger (Direction4 dir) {
                    if (direction == dir) {
                        tcs.TrySetResult();
                        data.leber.changeDirection4.RemoveListener(OnTrigger);
                    }
                }
            }
        }
    }
}