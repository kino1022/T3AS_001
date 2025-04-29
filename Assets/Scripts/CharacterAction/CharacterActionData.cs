using System;
using System.Collections.Generic;
using UnityEngine;

namespace CharacterAction {
    /// <summary>
    /// キャラクターのアクションのデータ
    /// </summary>
    [Serializable]
    public class CharacterActionData : ScriptableObject {
        /// <summary>
        /// animator上のアニメーションの名前
        /// </summary>
        public string animationName;
        
        /// <summary>
        /// キャンセルルートのリスト
        /// </summary>
        public List<CancelRute> cancelRutes;
        
        /// <summary>
        /// あらゆるモーションからのキャンセルを許容するか
        /// </summary>
        public bool allowCancelAnyAction;
    }
}