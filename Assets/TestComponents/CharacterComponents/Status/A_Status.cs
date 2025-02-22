using GenerallySys.CollectionManageSys;
using System;
using UnityEngine;

namespace Test.Character.Status {
	/// <summary>
	/// 全てのステータスの基底クラス
	/// </summary>
	public abstract class A_Status : MonoBehaviour {

		[SerializeField] private string _statusName;

		private float _baseValue;
		/// <summary>
		/// 補正前の基礎値
		/// </summary>
		public float baseValue {
			get {
				if (_baseValue < _minValue) {
					return _minValue;
				}
				else if (_baseValue > _maxValue) {
					return _maxValue;
				}
				else {
					return _baseValue;
				}
			}
			set { _baseValue = value; }
		}

		private float _value;
		/// <summary>
		/// 補正値込みでの最終的な値
		/// </summary>
		public float value {
			get {
				if (_baseValue < _minValue) {
					return _minValue;
				}
				else if (_baseValue > _maxValue) {
					return _maxValue;
				}
				else {
					return _value;
				}
			}
			set { _value = value; }
		}

		[SerializeField] private float _maxValue;
		/// <summary>
		/// このステータスの取れる最大値
		/// </summary>
		public float maxValue {
			get { return _maxValue; } 
			set { _maxValue = value; }
		}

		[SerializeField] private float _minValue;
		/// <summary>
		/// このステータスの取れる最小値
		/// </summary>
		public float minValue {
			get { return _minValue; }
			set { _minValue = value; }
		}

		/// <summary>
		/// ステータス補正値の管理クラス
		/// </summary>
		[SerializeField] public A_CollectionManager statusCollection;
<<<<<<< HEAD
=======

		/// <summary>
		/// 値が変化された際に発火されるイベント
		/// </summary>
		public Action wasValueChanged;

		private void Start () {

			if (statusCollection != null) {
				Debug.Log($"{_statusName}の補正値マネージャーがアタッチされていません！");
			}
			else {
				statusCollection.wasChanged += CollectionValueWasChanged;
			}

			WasStartColled();
		}

		/// <summary>
		/// 補正値の変化によって呼び出されて_valueを補正値込みの値で再計算する
		/// </summary>
		/// <param name="ratio"></param>
		/// <param name="fix"></param>
		private void CollectionValueWasChanged (float ratio,float fix) {
			value = _baseValue * ratio + fix;
		}

		/// <summary>
		/// Startメソッドの最後に呼び出されるメソッド
		/// </summary>
		protected virtual void WasStartColled () {

		}
>>>>>>> 7c36da2671f2e2df3a8a22bfe68c8a3a76dee36f
	}
}