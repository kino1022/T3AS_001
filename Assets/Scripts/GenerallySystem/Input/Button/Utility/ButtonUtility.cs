using System;
using Cysharp.Threading.Tasks;
using GenerallySys.Definition;

namespace GenerallySys.Input.Button.Utility {
    /// <summary>
    /// A_Button関連のメソッドやタスクを扱うクラス
    /// </summary>
    public static class ButtonUtility {
        /// <summary>
        /// 指定したボタンが指定時間以内に特定の状態に遷移したなら真、時間が超過したなら偽を返すタスク
        /// </summary>
        /// <param name="button">指定するボタン</param>
        /// <param name="condition">指定する状態</param>
        /// <param name="timeout">制限時間</param>
        /// <returns></returns>
        public static async UniTask<Boolean> WaitForAnyCondition(A_Button button,ButtonCondition condition,float timeout) {
            var tcs = new UniTaskCompletionSource();
            button.conditionChanged.AddListener(OnTrigger);
            var completation = await UniTask.WhenAny(
                tcs.Task, 
                UniTask.Delay(TimeSpan.FromSeconds(timeout))
                );
            
            if (completation == 1) return true;
            else return false;

            void OnTrigger(ButtonCondition input) {
                if (input == condition) {
                    tcs.TrySetResult();
                    button.conditionChanged.RemoveListener(OnTrigger);
                }
            }
        }
    }
}