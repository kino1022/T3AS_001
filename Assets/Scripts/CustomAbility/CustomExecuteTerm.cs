using System;
using Unity.VisualScripting;
using UnityEngine;

namespace CustomAbility {
    /// <summary>
    /// カスタムアビリティの発動条件を表記する
    /// </summary>
    [System.Serializable]
    public class CustomExecuteTerm  {
        
        /// <summary>
        /// 条件の名前
        /// </summary>
        public string TermName;
        
        /// <summary>
        /// 発動条件を満たした際に発火するイベント
        /// </summary>
        public Action OnExecuteEvent;
        /// <summary>
        /// 発動条件を満たさなくなった際に発火されるイベント
        /// </summary>
        public Action OnDisExecuteEvent;
    }
}