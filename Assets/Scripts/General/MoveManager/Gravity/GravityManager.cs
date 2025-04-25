using UnityEngine;

namespace General.MoveManager.Gravity {
    /// <summary>
    /// 重力を管理するコンポーネント
    /// </summary>
    public class GravityManager : MovementManager {
        /// <summary>
        /// 
        /// </summary>
        [SerializeField] public bool enableGravity = true;

        [SerializeField] private CharacterController cc;
        
        [SerializeField] private float gravity;

        private void Start() {
            cc = GetComponent<CharacterController>();
            if (cc == null) Debug.LogWarning("Character controller component not found!");
        }

        private void Update() {
            if (GetIsEnableGravity()) {
                Movement = new Vector3(0.0f, -gravity, 0.0f);
            }
            else {
                Movement = Vector3.zero;
            }
        }
        
        /// <summary>
        /// 重力を適応すべきかを返すメソッド
        /// </summary>
        /// <returns></returns>
        private bool GetIsEnableGravity() {
            return !cc.isGrounded && enableGravity ? true : false;
        }
    }
}