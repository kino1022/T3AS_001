using System;
using Cysharp.Threading.Tasks;
using General.Difinition;
using General.Status;
using General.Status.Interface;
using UnityEngine;

namespace WeaponAbility.Template.Term {
    [System.Serializable]
    [CreateAssetMenu(menuName = "Ability/WeaponAbility/CustomTerm/ステータス割合依存")] 
    public class TermOfStatusRatio :ExecuteTerm {
        
        public CurrentStatus Status;
        /// <summary>
        /// 指定した割合より下で発動か上で発動かを示す
        /// </summary>
        public HighAndLow highAndLow;
        
        /// <summary>
        /// 発動のラインになる割合
        /// </summary>
        public float executeRatio;
        
        public override void SetUpTerm() {
            base.SetUpTerm();
            CheckStatusRatio().Forget();
        }
        
        /// <summary>
        /// ステータスの割合を
        /// </summary>
        private async UniTask CheckStatusRatio() {
            while (!cts.Token.IsCancellationRequested) {
                await UniTask.WaitForEndOfFrame();
                if (GetIsExecute() && !isExecuting) {
                    isExecuting = true;
                    OnExecuteEvent?.Invoke();
                }
                else if (GetIsExecute() && isExecuting) {
                    isExecuting = false;
                    OnDisExecuteEvent?.Invoke();
                }
            }
            isExecuting = false;
        }

        private bool GetIsExecute() {
            if (highAndLow == HighAndLow.High && executeRatio < Status.valueRatio) return true;
            else if (highAndLow == HighAndLow.Low && executeRatio > Status.valueRatio) return true;
            return false;
        }
    }
}