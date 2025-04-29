using System;
using UnityEngine;

namespace CharacterAction {
    /// <summary>
    /// 実行中のアニメーションのフレーム数をカウントするクラス
    /// </summary>
    [Serializable]
    public class AnimatorFrameCounter {
        /// <summary>
        /// 現在の経過フレーム
        /// </summary>
        [SerializeField] public int currentFrame;
        
        [SerializeField] private Animator animator;

        private float GetFrameFromCurrentAnimatorClipInfo(AnimatorClipInfo clip) {
            AnimationClip clipClip = clip.clip;
            
            return 0.0f;
        }
        
        /// <summary>
        /// AnimatorコンポーネントからStateInfoを取得するメソッド
        /// </summary>
        /// <returns></returns>
        private AnimatorStateInfo GetAnimatorStateInfo(int layerIndex) {
            return animator.GetCurrentAnimatorStateInfo(layerIndex);
        }
        
        /// <summary>
        /// AnimatorからClipInfoを取得するメソッド
        /// </summary>
        /// <param name="layerIndex"></param>
        /// <returns></returns>
        private AnimatorClipInfo[] GetClipInfo(int layerIndex) {
            return animator.GetCurrentAnimatorClipInfo(layerIndex);
        }
        
        /// <summary>
        /// BrendWeightを基準にメインで再生されているアニメーションクリップを判断する
        /// </summary>
        /// <param name="clips"></param>
        /// <returns></returns>
        private AnimatorClipInfo GetMainAnimationClipInfo(AnimatorClipInfo[] clips) {
            var mainClip = clips[0];
            for (int i = 0; i < clips.Length; i++) {
                if (mainClip.weight < clips[i].weight) {
                    mainClip = clips[i];
                }
            }
            return mainClip;
        }
    }
}