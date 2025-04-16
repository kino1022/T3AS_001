using UnityEngine;
using UnityEngine.InputSystem;

namespace GenerallySys.Input.Lever {
    /// <summary>
    /// 全てのレバーやスティックの規定クラス
    /// </summary>
    public abstract class A_Lever : MonoBehaviour {
        /// <summary>
        /// レバーの方向データ
        /// </summary>
        [SerializeField] public LeverPosData posData;

        private void Start() {
            posData = new LeverPosData();
        }
        
        /// <summary>
        /// InputSystemから呼び出されるメソッド
        /// </summary>
        /// <param name="context"></param>
        public void OnStick(InputAction.CallbackContext context) {
            if (context.performed) {
                posData.pos = context.ReadValue<Vector2>();
            }
        }
    }
}