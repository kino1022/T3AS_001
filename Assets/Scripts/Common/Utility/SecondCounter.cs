using System;
using Cysharp.Threading.Tasks;

namespace Common.Utility {
    /// 秒数のカウントを行うクラス
    [Serializable]
    public class SecondCounter : ACounter {
        public SecondCounter () : base() {
            
        }
        
        protected override void OnInitialize() {
            base.OnInitialize();
            SecondCountTask().Forget();
        }

        private async UniTask SecondCountTask () {
            while (!cts.Token.IsCancellationRequested) {
                await UniTask.WaitForSeconds(0.1f);
                CurrentCount += 0.1f;
                if (cts.IsCancellationRequested) break;
                if (!IsActive) await UniTask.WaitUntil(() => IsActive);
            }
        }
    }
}