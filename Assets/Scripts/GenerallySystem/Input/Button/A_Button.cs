using System;
using Cysharp.Threading.Tasks;
using GenerallySys.Definition;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

namespace GenerallySys.Input.Button {
    /// <summary>
    /// 全てのボタン管理クラスの基底クラス
    /// </summary>
    public abstract class A_Button : MonoBehaviour {
        [SerializeField] private ButtonData data;
        
        private ButtonCondition _condition;
        /// <summary>
        /// ボタンの押下状態
        /// </summary>
        public ButtonCondition condition {
            get {return _condition;}
            set {
                if (condition != value) {
                    value = _condition;
                    conditionChanged?.Invoke(_condition);
                    if (condition == ButtonCondition.Hold) {
                        CounterWhenButtonHold().Forget();
                    }
                }
            }
        }
        
        /// <summary>
        /// ボタンの状態が変化した際に発火されるイベント
        /// </summary>
        public UnityEvent<ButtonCondition> conditionChanged;
        /// <summary>
        /// ボタンが長押しから離された際に、長押しされた時間を添付して発火されるイベント
        /// </summary>
        public UnityEvent<float> wasRelease;

        private void Start() {
            
        }
        
        /// <summary>
        /// InputSystemから呼び出されるメソッド
        /// </summary>
        /// <param name="context"></param>
        public void OnButton(InputAction.CallbackContext context) {
            if (context.performed) {
                condition = ButtonCondition.Press;
                PhaseHoldTimer().Forget();
            }

            if (context.canceled) {
                condition = ButtonCondition.None;
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        private async UniTask PhaseHoldTimer() {
            var wasrelease = await GetReleaseOrTimeOut(data.phaseHold);
            if (!wasrelease) condition = ButtonCondition.Hold;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="require"></param>
        /// <returns></returns>
        private async UniTask<Boolean> GetReleaseOrTimeOut(float require) {
            var tcs = new UniTaskCompletionSource();
            conditionChanged.AddListener(OnTrigger);
            var completatiion = await UniTask.WhenAny(
                tcs.Task,
                UniTask.Delay(TimeSpan.FromSeconds(require))
                );

            if (completatiion == 1) return true;
            else return false;
            

            void OnTrigger(ButtonCondition condition) {
                if (condition != ButtonCondition.Hold) {
                    tcs.TrySetResult();
                    conditionChanged.RemoveListener(OnTrigger);
                }
            }
        }
        /// <summary>
        /// ボタンが長押しされた時間をカウントするタスク
        /// </summary>
        /// <param name="countInterval"></param>
        private async UniTask CounterWhenButtonHold(float countInterval = 0.017f) {
            float count = 0.0f;
            while (condition == ButtonCondition.Hold) {
                if (this.GetCancellationTokenOnDestroy().IsCancellationRequested) {
                    return;
                }
                await UniTask.Delay(TimeSpan.FromSeconds(countInterval));
                count += countInterval;
            }
            wasRelease?.Invoke(count);
        }
    }
}