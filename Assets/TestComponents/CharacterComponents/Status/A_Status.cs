using GenerallySys.CollectionManageSys;
using System;
using UnityEngine;

namespace Test.Character.Status {
	/// <summary>
	/// 全てのステータスの基底クラス
	/// </summary>
	public abstract class A_Status : MonoBehaviour {

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

		public float maxValue {
			get { return _maxValue; } 
			set { _maxValue = value; }
		}

		[SerializeField] private float _minValue;

		public float minValue {
			get { return _minValue; }
			set { _minValue = value; }
		}

		/// <summary>
		/// ステータス補正値の管理クラス
		/// </summary>
		[SerializeField] public A_CollectionManager statusCollection;
	}
}