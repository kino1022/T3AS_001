using System;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;

namespace WeaponAbility {
    /// <summary>
    /// カスタムアビリティの発動条件を表記する
    /// </summary>
    [System.Serializable]
    public abstract class ExecuteTerm : ScriptableObject  {
        
        /// <summary>
        /// 条件の名前
        /// </summary>
        public string termName;
        /// <summary>
        /// 発動条件を満たした際に発火するイベント
        /// </summary>
        public Action OnExecuteEvent;
        /// <summary>
        /// 発動条件を満たさなくなった際に発火されるイベント
        /// </summary>
        public Action OnDisExecuteEvent;
        
        /// <summary>
        /// 条件を満たして発動しているかどうか
        /// </summary>
        public bool isExecuting = false;
        
        /// <summary>
        /// 条件の処理に使うタスクのためのCancellationToken
        /// </summary>
        protected CancellationTokenSource cts = new CancellationTokenSource();

        public virtual void SetUpTerm() {
            CancellationToken token = cts.Token;
        }

        public virtual void OnRemove() {
            cts.Cancel();
        }
    }
}