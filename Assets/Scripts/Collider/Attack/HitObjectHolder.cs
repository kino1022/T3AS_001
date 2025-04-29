using System;
using System.Collections.Generic;
using Common.Interface;
using UnityEngine;

namespace Collider.Attack {
    /// <summary>
    /// 攻撃判定に衝突したオブジェクトを記録するクラス
    /// (この中で記録されているオブジェクトに対してはダメージ等は発生しない)
    /// </summary>
    [Serializable]
    public class HitObjectHolder : ISetUpInStart {
        
        private List<HitObject> hitObjects = new List<HitObject>();

        [SerializeField] private float collisionDuration;

        public void SetUpInStart() {
            
        }
        
        /// <summary>
        /// ヒットオブジェクトインスタンス内に指定されたゲームオブジェクトが存在しているかどうか返すメソッド
        /// </summary>
        /// <param name="gameObject"></param>
        /// <returns></returns>
        public bool GetExistAnyGameObject(GameObject gameObject) {
            foreach (var element in hitObjects) {
                if (element.hitObject == gameObject) return true;
            }
            return false;
        }
    }
}