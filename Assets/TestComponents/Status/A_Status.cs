using GenerallySys.CollectionManageSys;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Test.Status {
	/// <summary>
	/// ステータス管理コンポーネントの基底クラス
	/// </summary>
	public class A_Status : MonoBehaviour {

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
			collection.wasChanged.AddListener(value = WasCollectionValueChanged());
		}

		private void Update () {
			
		}

		private float WasCollectionValueChanged () {
			
		}
	}
}
