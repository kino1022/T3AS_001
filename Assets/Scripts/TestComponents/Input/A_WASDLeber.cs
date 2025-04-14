using System;
using UnityEngine;
using UnityEngine.InputSystem;
using GenerallySys.Definition.Direction;
using static GenerallySys.Utility.DirectionUtility;

namespace Test.Input {
    public abstract class A_WASDLeber : A_Leber {
        
        private Direction2H _horizontal = new Direction2H();
        /// <summary>
        /// 縦方向の入力情報
        /// </summary>
        public Direction2H horizontal {
            set {
                _horizontal = value;
                Direction2hChanged?.Invoke();
            }
        }
        /// <summary>
        /// 横方向の入力状態が変化した際に呼び出されるイベント
        /// </summary>
        public Action Direction2hChanged;
        
        private Direction2V _vertical = new Direction2V();
        /// <summary>
        /// 横方向の入力情報
        /// </summary>
        public Direction2V vertical {
            set {
                _vertical = value;
                Direction2vChanged?.Invoke();
            }
        }
        /// <summary>
        /// 縦方向の入力状態が変化した際に呼び出されるイベント
        /// </summary>
        public Action Direction2vChanged;

        protected override void WasStartLoaded() {
            base.WasStartLoaded();
            Direction2vChanged += Direction2Changed;
            Direction2hChanged += Direction2Changed;
        }
        
        /// <summary>
        /// 各種2方向変数の変化に反応して呼び出され、二次元ベクトルへの変換を行うメソッド
        /// </summary>
        private void Direction2Changed() {
            pos = ChangeDirection2Vector2(_horizontal, _vertical);
        }
        
        /// <summary>
        /// InputSystemから呼び出されるメソッド
        /// </summary>
        /// <param name="context"></param>
        public void OnFront(InputAction.CallbackContext context) {
            if (context.performed) {
                vertical = Direction2V.F2V;
            }
            if (context.canceled) {
                if (_vertical != Direction2V.B2V) vertical = Direction2V.N2V;
            }
        }
        /// <summary>
        /// InputSystemから呼び出されるメソッド
        /// </summary>
        /// <param name="context"></param>
        public void OnBack(InputAction.CallbackContext context) {
            if (context.performed) {
                vertical = Direction2V.B2V;
            }
            if (context.canceled) {
                if (_vertical != Direction2V.F2V) vertical = Direction2V.N2V;
            }
        }
        /// <summary>
        /// InputSystemから呼び出されるメソッド
        /// </summary>
        /// <param name="context"></param>
        public void OnRight(InputAction.CallbackContext context) {
            if (context.performed) {
                horizontal = Direction2H.R2H;
            }
            else if (context.canceled) {
                if (_horizontal != Direction2H.L2H) horizontal = Direction2H.N2H;
            }
        }
        /// <summary>
        /// InputSystemから呼び出されるメソッド
        /// </summary>
        /// <param name="context"></param>
        public void OnLeft(InputAction.CallbackContext context) {
            if (context.performed) {
                horizontal = Direction2H.L2H;
            }
            if (context.canceled) {
                if (_horizontal != Direction2H.R2H) horizontal = Direction2H.N2H;
            }
        }
    }
}