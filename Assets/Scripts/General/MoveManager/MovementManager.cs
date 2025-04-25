using UnityEngine;

namespace General.MoveManager {
    public class MovementManager : MonoBehaviour {
        
        [SerializeField] private Vector3 movement;
        
        /// <summary>
        /// ベクトルを丸め処理する際に参照する閾値
        /// </summary>
        [SerializeField] private Vector3 threhold;
        
        /// <summary>
        /// ベクトルに対して丸め処理をするかどうか
        /// </summary>
        [SerializeField] private bool isRounding;

        /// <summary>
        /// このマネージャが管理しているベクトルの総量
        /// </summary>
        public Vector3 Movement {
            get { return movement; }
            set {
                if (isRounding) RoundingVector(value);
                movement = value;
            }
        }
        
        /// <summary>
        /// 閾値を元にしてベクトルの丸め処理を行うメソッド
        /// </summary>
        /// <param name="vec"></param>
        /// <returns></returns>
        private Vector3 RoundingVector (Vector3 vec) {
            if (Mathf.Abs(vec.x) < threhold.x) vec.x = 0;
            if (Mathf.Abs(vec.y) < threhold.y) vec.y = 0;
            if (Mathf.Abs(vec.z) < threhold.z) vec.z = 0;
            return vec;
        }
        
    }
}