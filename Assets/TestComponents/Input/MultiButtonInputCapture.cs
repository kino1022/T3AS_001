using System;
using System.Collections.Generic;
using System.Threading;
using Cysharp.Threading.Tasks;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

namespace Test.Input {
    /// <summary>
    /// 指定した間隔・順番のボタン入力を検知してイベントを発火する
    /// </summary>
    public class MultiButtonInputCapture : MonoBehaviour {
        /// <summary>
        /// 要求入力データ
        /// </summary>
        [SerializeField] private MultiButtonInputData _data;
        /// <summary>
        /// 入力成立時に発火されるイベント
        /// </summary>
        public UnityEvent couseEvent;

        private void Start () {
            _data.buttonsPattern[1].wasPress.AddListener(StartInputCapture);
        }

        private void StartInputCapture () {
            Debug.Log($"{this.name}の連続入力検知タスクを起動します");
            InputCapture(this.GetCancellationTokenOnDestroy(),_data.buttonsPattern,_data.interval).Forget();
        }

        async private UniTaskVoid InputCapture (CancellationToken token,List<A_Button> pattern,List<float> interval) {
            try{
                var succese = true;
                Debug.Log($"{this.name}の連続入力検知タスクを開始します");
                for (int i = 0; i < pattern.Count; i++) {
                    var wasInput = await WaitForUnityEvent(pattern[i].wasPress,interval[i]);

                    if (wasInput) {
                        Debug.Log($"{i + 2}回目の入力判定に成功しました{i + 3}回目の入力判定に移行します。");
                    }
                    else {
                        succese = false;
                        break;
                    }
                }

                if (succese) {
                    Debug.Log($"{this.name}の連続入力判定に成功しました");
                    couseEvent?.Invoke();
                }
                else {
                    Debug.Log($"{this.name}の連続入力判定に失敗しました");
                }
            }
            catch (OperationCanceledException) {

            }
            finally {

            }
        }

        public async UniTask<Boolean> WaitForUnityEvent (UnityEvent unityEvent,float timeout) {
            try {
                var tcs = new UniTaskCompletionSource();//CompletionSourseのインスタンス化処理

                unityEvent.AddListener(OnTrigger);//発火時コールバックのリスナー適用処理

                var completedTask = await UniTask.WhenAny(tcs.Task,UniTask.Delay(TimeSpan.FromSeconds(timeout)));

                if (completedTask == 0) {
                    return true;
                }
                else {
                    return false;
                }

                void OnTrigger () {
                    tcs.TrySetResult();
                    unityEvent.RemoveListener(OnTrigger);
                }
            }
            catch (OperationCanceledException) {
                return false;
            }
            finally {

            }
        }
    }
}