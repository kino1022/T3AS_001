using GenerallySys.CollectionManageSys;
using System.Collections;
using System.Collections.Generic;
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
			get { return _baseValue; }
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
			get { return _value; }
			set { _value = value; }
		}

		private void Start () {
			_collection = GetComponent<A_CollectionManager>();
			_collection.wasChanged += wasChangeCollections;
		}

		private void Update () {
			
		}

		/// <summary>
		/// 補正値の値が変化した際に呼び出されて、変化後の補正値を計算した値でvalueを上書きするメソッド
		/// </summary>
		/// <param name="ratioValue"></param>
		/// <param name="fixedValue"></param>
		private void wasChangeCollections (float ratioValue,float fixedValue) {
			_value = (baseValue * ratioValue) + fixedValue;
		}
		/// <summary>
		/// ステータスの元の値を変化するメソッド
		/// </summary>
		/// <param name="changeValue">変化量</param>
		public void ChangeBaseValue (float changeValue) {
			Debug.Log($"{changeValue}分、{_statusName}の値を変化させます");
			_baseValue += changeValue;
		}
	}
}
