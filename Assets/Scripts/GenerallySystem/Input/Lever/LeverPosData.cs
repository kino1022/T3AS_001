using System;
using GenerallySys.Definition.Direction;
using UnityEngine;
using UnityEngine.Events;
using static GenerallySys.Utility.DirectionUtility;

namespace GenerallySys.Input.Lever {
    /// <summary>
    /// レバーの方向状態を管理しているクラス
    /// </summary>
    [Serializable]
    public class LeverPosData {
        private Vector2 _pos = Vector2.zero;
        /// <summary>
        /// Vector2形式で表現したレバーの位置
        /// </summary>
        public Vector2 pos {
            get {return _pos;}
            set {
                if (_pos != value) {
                    _pos = value;
                    ChangePos?.Invoke(_pos);
                }
            }
        }

        private Direction4 _direction4;
        /// <summary>
        /// 4方向に抽象化した際のレバーの位置
        /// </summary>
        public Direction4 direction4 {
            get {return _direction4;}
            set {
                if (_direction4 != value) {
                    _direction4 = value;
                    ChangeDirection4?.Invoke(_direction4);
                }
            }
        }

        private Direction8 _direction8;
        /// <summary>
        /// 8方向に抽象化した際のレバーの方向
        /// </summary>
        public Direction8 direction8 {
            get {return _direction8;}
            set {
                if (_direction8 != value) {
                    _direction8 = value;
                    ChangeDirection8?.Invoke(_direction8);
                }
            }
        }

        /// <summary>
        /// 入力状態が変化した際に呼び出されるイベント
        /// </summary>
        public UnityEvent<Vector2> ChangePos;
        /// <summary>
        /// 4方向が変化した際に呼び出されるイベント
        /// </summary>
        public Action<Direction4> ChangeDirection4;
        /// <summary>
        /// 8方向が変化した際に呼び出されるイベント
        /// </summary>
        public Action<Direction8> ChangeDirection8;
        
        public LeverPosData() {
            ChangePos.AddListener(WasChangedPos);
        }

        private void WasChangedPos(UnityEngine.Vector2 vec) {
            direction4 = ChangeVector2ForDireciton4(vec);
            direction8 = ChangeVector2ForDireciton8(vec);
        }
        
    }
}