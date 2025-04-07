using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using Cysharp.Threading.Tasks;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

namespace Test.Input {
    /// <summary>
    /// ボタンの連続入力を検知して対応するイベントを発火するコンポーネント
    /// </summary>
    public class MultiButtonInputCapture : MonoBehaviour {
        /// <summary>
        /// 実装する連続入力のデータ
        /// </summary>
        /// <returns></returns>
        [SerializeField] private List<MultiButtonInputData> _datas;
        /// <summary>
        /// オブジェクトに対してアタッチされているボタンの可変長配列
        /// </summary>
        private List<A_Button> _buttons;
        /// <summary>
        /// 入力判定クラスのリスト
        /// </summary>
        private List<CaptureSystem> _capture;

        void Start () {
            if (_datas == null){
                Debug.Log("連続入力データが存在していません");
            }

            for (int i = 0; i < _datas.Count; i++ ) {
                _capture.Add(new CaptureSystem(_datas[i]));
            }
        }
        /// <summary>
        /// 特定の入力判定クラスと入力判定データをリストから除外するメソッド
        /// </summary>
        /// <param name="target"></param>
        public void RemoveTargetCapture (MultiButtonInputData target) {
            foreach (var data in _datas) {
                if (data == target) {
                    _datas.Remove(target);
                    foreach (var cap in _capture) {

                        ///もしかしたら
                        /// _datasと同じ順番にある_captureを抽出する
                        /// cap.data == dataならそのままremove
                        /// cap.data != dataならリストからソートしてヒットしたものをRemove
                        /// の方が早いかもしれない。ただ運用条件にもよるのでなんとも言えない
                        if (cap.data == target){
                            _capture.Remove(cap);
                        }
                    }
                }
            }
        }
        /// <summary>
        /// 特定の入力データを追加して入力判定を開始するメソッド
        /// </summary>
        /// <param name="data"></param>
        public void AddNewInputData (MultiButtonInputData data) {
            _datas.Add(data);
            _capture.Add(new CaptureSystem(data));
        } 
    }
    /// <summary>
    /// 入力成立を判定するクラス
    /// </summary>
    partial class CaptureSystem {
        public MultiButtonInputData data;
        public CaptureSystem (MultiButtonInputData data) {
            this.data = data;

            data.buttonsPattern[0].wasPress.AddListener(ButtonOnTrigger);
        }
        /// <summary>
        /// ボタン入力があった際に発火されるイベント
        /// </summary>
        private void ButtonOnTrigger () {
            InputCapture().Forget();
        }
        /// <summary>
        /// 連続入力の全体の判定を行うためのタスク
        /// </summary>
        /// <returns></returns>
        private async UniTask InputCapture () {
            Boolean success = true;
            for (int i = 0; i < data.buttonsPattern.Count - 1; i++ ) {
                var wasInput = await WaitForButtonPress(data.buttonsPattern[i + 1],data.interval[i]);
                if (!wasInput) {
                    success = false;
                    break;
                }
            }
            if (success) data.couseEvent?.Invoke();
        }
        /// <summary>
        /// 入力一つ一つの判定を行うタスク
        /// </summary>
        /// <param name="button">入力を判定するボタン</param>
        /// <param name="grace">入力の猶予</param>
        /// <returns></returns>
        private async UniTask<Boolean> WaitForButtonPress (A_Button button,float grace) {
            var tcs = new UniTaskCompletionSource();
            button.wasPress.AddListener(OnTrigger);

            var completedTask = await UniTask.WhenAny(tcs.Task,UniTask.Delay(TimeSpan.FromSeconds(grace)));

            if (completedTask == 1) return true;
            else return false;

            void OnTrigger () {
                tcs.TrySetResult();
                button.wasPress.RemoveListener(OnTrigger);
            }
        }
    }
}