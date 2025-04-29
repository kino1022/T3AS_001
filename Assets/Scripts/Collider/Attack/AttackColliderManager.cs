using System.Collections.Generic;
using Common.Interface;
using Damage;
using UnityEngine;
using UnityEngine.Events;
using static Common.Utility.InterfaceUtility;

namespace Collider.Attack {
    /// <summary>
    /// 
    /// </summary>
    public class AttackColliderManager : MonoBehaviour {
        
        /// <summary>
        /// 当たり判定
        /// </summary>
        [SerializeField] private UnityEngine.Collider collider;

        /// <summary>
        /// 発生しているダメージの総量
        /// </summary>
        [SerializeField] public List<Damage.Damage> damages;
        
        
        [SerializeField] HitObjectHolder hitHolder;
        
        /// <summary>
        /// オブジェクトが衝突した際に発火されるイベント
        /// </summary>
        [SerializeField] public UnityEvent<GameObject> hitObjectUEvent;

        private void Start() {
            SetUp();
        }

        public void Update() {
            
        }
        
        public void SetUp() {
            var interfaces = Common.Utility.InterfaceUtility.GetAnyInterfaces<ISetUpInStart>(this);
            foreach (var element in interfaces) {
                element.SetUpInStart();
            }
        }

        private void Ontrigger(UnityEngine.Collider other) {
            hitObjectUEvent?.Invoke(other.gameObject);
            if (hitHolder.GetExistAnyGameObject(other.gameObject)) return;
        }
    }
}