using System;
using System.Threading;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace Common.Utility {
    [Serializable]
    public class FrameCounter : ACounter {
        
        public FrameCounter() : base() {
            
        }

        protected override void OnInitialize() {
            base.OnInitialize();
            FrameCount().Forget();
        }

        ///フレームのカウントを行うタスク
        private async UniTask FrameCount() {
            while (!cts.Token.IsCancellationRequested) {
                await UniTask.DelayFrame(1);
                CurrentCount++;
                if (cts.Token.IsCancellationRequested) {
                    break;
                }
                if (!IsActive) {
                    await UniTask.WaitUntil(() => IsActive == true);
                }
            }
        }
    }
}