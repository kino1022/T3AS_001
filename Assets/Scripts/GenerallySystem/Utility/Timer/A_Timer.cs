using System;
using System.Threading;
using Cysharp.Threading.Tasks;

namespace GenerallySys.Utility.Timer {
    /// <summary>
    /// 汎用タイマーの基底クラス
    /// </summary>
    public abstract class A_Timer {
        private float _restTime = 0.0f;
        /// <summary>
        /// タイマーの残り時間
        /// </summary>
        /// <value></value>
        public float restTime {
            get {return _restTime;}
            set {
                _restTime = value;
                if (_restTime <= 0.0f) {
                    wasZero?.Invoke();
                }
            }
        }
        /// <summary>
        /// 進行時間に掛かる倍率
        /// </summary>
        private float _progressRate = 1.0f;
        /// <summary>
        /// タイマーが0になった際に発火されるイベント
        /// </summary>
        public Action wasZero;
        /// <summary>
        /// タイマーが進行中かどうか
        /// </summary>
        private Boolean _isProgress = true;

        protected CancellationToken taskToken;

        /// <summary>
        /// 残り時間の減少を行うタスク
        /// </summary>
        /// <param name="token"></param>
        /// <param name="interval">残り時間減少処理を行う感覚(秒)</param>
        /// <returns></returns>
        protected async UniTask DecreaseRestTime (CancellationToken token,float interval) {
            try{
                while (!token.IsCancellationRequested || _restTime <= 0.0f) {
                    //進行フラグがfalseならtrueになるまで待機
                    if (!_isProgress) await UniTask.WaitWhile(() => _isProgress);

                    await UniTask.Delay(TimeSpan.FromSeconds(interval));
                    restTime -= interval * _progressRate;
                }
            }
            catch (OperationCanceledException) {
            }
            finally {
            }
        }
        /// <summary>
        /// 残り時間を増減させる
        /// </summary>
        /// <param name="value">増減量</param>
        public void AddRestTime (float value) {
            restTime += value;
        }
        /// <summary>
        /// 進行倍率を変化させる
        /// </summary>
        /// <param name="newRate"></param>
        public void ChangeProgressRate (float newRate) {
            _progressRate = newRate;
        }
    }
}