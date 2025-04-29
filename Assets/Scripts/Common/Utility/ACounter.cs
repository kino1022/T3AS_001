using System.Threading;

namespace Common.Utility {
    /// 単位時間をカウントするカウンタークラスの基底クラス
    public class ACounter {
        /// 現在の経過カウント
        public float CurrentCount = 0;
        /// カウンターが現在動いているかどうか
        public bool IsActive = true;
        /// カウンター停止の為のcts
        protected CancellationTokenSource cts = new CancellationTokenSource();

        public ACounter() {
            CancellationToken token = cts.Token;
            Initialize();
        }

        protected void Initialize() {
            OnInitialize();
        }

        protected virtual void OnInitialize() {
            
        }

        public void CancelCountTask() {
            cts.Cancel();
        }
    }
}