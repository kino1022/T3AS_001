using GenerallySys.CollectionManageSys;
using GenerallySys.CollectionManageSys.Test;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnityEngine;

namespace Test.Status {
	/// <summary>
	/// ステータス管理コンポーネントの基底クラス
	/// </summary>
	public class A_Status : MonoBehaviour {

		/// <summary>
		/// ステータスの名前
		/// </summary>
		[SerializeField] private string _statusName;

		[SerializeField] private float _baseValue = 0.0f;
		/// <summary>
		/// ステータスの基礎量
		/// </summary>
		public float baseValue {
			get {
				//0以下の際に参照されると0を返す仕様
				if (_baseValue <= 0f) {
					return 0;
				}
				else {
					return _baseValue;
				}
			}
			set {
				_baseValue = value;
				wasChangeCollections(_collection.totalRatio, _collection.totalFixed);
				wasValueChanged?.Invoke(_baseValue, _value);
			}
		}

		[SerializeField] private A_CollectionManager _collection;

		/// <summary>
		/// 補正値管理コンポーネント(読み込み専用)
		/// </summary>
		public A_CollectionManager collection {
			get { return _collection; }
		}

		private float _value = 0.0f;
		/// <summary>
		/// 補正値等込みでのステータスの値
		/// </summary>
		public float value {
<<<<<<< Updated upstream
			get { 
				//0以下の場合に参照されると0を返す仕様
				if (_value <= 0f) {
					return 0;
				}
				else {
					return _value;
				}
			}
			set {
				_value = value;
				wasValueChanged?.Invoke(_baseValue, _value);
=======
			get { return _value; }
			set {
				if (_value != _value + value) {
					_value = value;
					wasValueChanged?.Invoke(_value);
				}
>>>>>>> Stashed changes
			}
		}

		/// <summary>
<<<<<<< Updated upstream
		/// 値が変化した際に発火されるイベント。引数は(baseValue,value)の順。
		/// </summary>
		public Action<float, float> wasValueChanged;
=======
		/// ステータスの値が変化した際に発火されるイベント
		/// </summary>
		public Action<float> wasValueChanged;
>>>>>>> Stashed changes

		private void Start () {
			_collection = GetComponent<A_CollectionManager>();
			_collection.wasChanged += wasChangeCollections;
		}

		/// <summary>
		/// 補正値の値が変化した際に呼び出されて、変化後の補正値を計算した値でvalueを上書きするメソッド
		/// </summary>
		/// <param name="ratioValue"></param>
		/// <param name="fixedValue"></param>
		private void wasChangeCollections (float ratioValue,float fixedValue) {
			_value = (baseValue * ratioValue) + fixedValue;
		}
	}
}
