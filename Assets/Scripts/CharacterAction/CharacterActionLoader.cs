using System;
using System.Linq;
using System.Security;
using UnityEngine;

namespace CharacterAction {
    public class CharacterActionLoader : MonoBehaviour {
        /// <summary>
        /// アタッチされているAnimator
        /// </summary>
        [SerializeField] private Animator animator;
        
        /// <summary>
        /// キャラクターアクションの管理クラス
        /// </summary>
        [SerializeField] private CharacterActionManager actionManager;
        
        /// <summary>
        /// 実行中のアクション
        /// </summary>
        [SerializeField] private CharacterAction currentAction;
        
        /// <summary>
        /// 新規アクションが実行された際に発火されるイベント
        /// </summary>
        public Action ActionLoadedEvent;
        
        private void Start() {
            animator = GetComponent<Animator>();
            if (animator == null) {
                Debug.LogWarning("No animator attached");
            }
        }
        
        /// <summary>
        /// 実行中のアクションを指定したアクション
        /// </summary>
        /// <param name="cancelAction"></param>
        /// <returns></returns>
        /*private bool GetAbleCancelAnimation(CharacterAction cancelAction) {
            if (currentAction == null) {
                //Actionが実行されていない際にはエラーを返す
                return false;
            }
            if (cancelAction.data.allowCancelAnyAction) return true;
            else {
                foreach (var cancelrute in currentAction.data.cancelRutes) {
                       
                }
            }
        } */
    }
}