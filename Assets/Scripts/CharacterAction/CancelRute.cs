using System;
using System.Collections.Generic;
using UnityEngine;

namespace CharacterAction {
    /// <summary>
    /// CharacterActionの実行中にキャンセルできるキャンセル先のCharacterActionやキャンセル区間を管理するクラス
    /// </summary>
    [Serializable]
    public class CancelRute : ScriptableObject {
        /// <summary>
        /// キャンセル可能フレームの開始区間
        /// </summary>
        public int startFrame;
        /// <summary>
        /// キャンセル可能フレームの終了区間
        /// </summary>
        public int endFrame;

        /// <summary>
        /// その区間でキャンセル可能なアクション
        /// </summary>
        public List<CharacterAction> actions;
        
        
        
        
        /// <summary>
        /// 指定したアクションがこのキャンセルルートに定義されているか
        /// </summary>
        /// <param name="cancelAction"></param>
        /// <returns></returns>
        public bool GetExistAnyActionInCancelRute(CharacterAction cancelAction) {
            return actions.Contains(cancelAction);
        }
        
        /// <summary>
        /// 指定したアクションが指定したフレームの場合にキャンセルできるかどうかを返すメソッド
        /// </summary>
        /// <param name="cancelAction"></param>
        /// <param name="currentFrame"></param>
        /// <returns></returns>
        public bool GetAbleCancelAnyAction(CharacterAction cancelAction, float currentFrame) {
            return currentFrame >= startFrame && currentFrame <= endFrame && actions.Contains(cancelAction);
        }
    }
}