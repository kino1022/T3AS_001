using System;
using System.Threading;
using UnityEngine;

namespace Test.Definition {
    /// <summary>
    /// ゲームオブジェクトで共用するCancellationTokenを発行して管理するコンポーネント
    /// </summary>
    public class GeneralCancelToken : MonoBehaviour {

        public static CancellationTokenSource gcts {get; set;}

        private void Awake() {
            gcts = new CancellationTokenSource();
            CancellationToken token = gcts.Token;
        }

        private void OnDestroy() {
            gcts?.Cancel();
            gcts?.Dispose();
        }
    }
}