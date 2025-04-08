using GenerallySys.Definition.Direction;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using static GenerallySys.Definition.Direction.Direction4;
using static GenerallySys.Definition.Direction.Direction8;

namespace Test.Input {
	/// <summary>
	/// あらゆるスティックやレバーの基底クラス
	/// </summary>
	public abstract class A_Leber : MonoBehaviour {

		[SerializeField] private Vector2 _pos = Vector2.zero;
		/// <summary>
		///	Vector2形式でのレバーの位置
		/// </summary>
		public Vector2 pos {
			get { return _pos; }
			set { 
				if (_pos != value) {
					_pos = value;
					changePos?.Invoke(_pos);
				}
			}
		}
		/// <summary>
		/// レバーの位置が変化した際に発火されるイベント
		/// </summary>
		public UnityEvent<Vector2> changePos;

		private Direction4 _direction4;
		/// <summary>
		/// 四方向に抽象化した際のレバーの位置
		/// </summary>
		public Direction4 direction4 {
			get { return _direction4; }
			set { 
				_direction4 = value; 
			}
		}
		/// <summary>
		/// 四方向の入力状態が変化した際に発火されるイベント
		/// </summary>
		public UnityEvent<Direction4> changeDirection4;

		private Direction8 _direction8;
		/// <summary>
		/// 八方向に抽象化した際のレバーの位置
		/// </summary>
		public Direction8 direction8 {
			get { return _direction8; }
			set {
				_direction8 = value; 
			}
		}
		/// <summary>
		///	八方向の入力状態が変化した際に発火されるイベント
		/// </summary>
		public UnityEvent<Direction8> changeDirection8;

		private void Start () {
			
		}

		private void Update () {

		}
		
		/// <summary>
		/// inputActionから呼び出されるメソッド
		/// </summary>
		/// <param name="context"></param>
		public void OnStick (InputAction.CallbackContext context) {
			if (context.performed) {
				pos = context.ReadValue<Vector2>();
			}
		}
	}
}