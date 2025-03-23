using System;
using System.Threading;
using UnityEngine;

namespace Test.Definition {
    /// <summary>
    /// �Q�[���I�u�W�F�N�g�ŋ��p����CancellationToken�𔭍s���ĊǗ�����R���|�[�l���g
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