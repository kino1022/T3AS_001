using System;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace General.MoveManager.Inertial {
    [System.Serializable]
    public class Inertial {
        /// <summary>
        /// 働く力の大きさ
        /// </summary>
        private float force;
        
        /// <summary>
        /// 力の働く方向
        /// </summary>
        private Vector3 direction;
        
        /// <summary>
        /// 0.1秒ごとの減衰率
        /// </summary>
        private float damping;
        
        /// <summary>
        /// forceとdirectionを掛け合わせた合計の慣性量
        /// </summary>
        public Vector3 totalForce;

        public Action<Inertial> RemoveInertialEvent;

        public Inertial(float force, Vector3 direction, float damping = 0.98f) {
            this.force = force;
            this.direction = direction.normalized;
            this.damping = damping;
            this.totalForce = force * direction;

            Initialize();
            
            DampingForce().Forget();
        }

        private void Initialize() {
            OnInitialize();
        }
        
        protected virtual void OnInitialize () {}

        private async UniTask DampingForce() {
            while (force < 0) {
                force *= damping;
                totalForce = force * direction;
            }
            RemoveInertialEvent?.Invoke(this);
        }
    }
}