using GenerallySys.CollectionManageSys;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Test.Status {
	/// <summary>
	/// �X�e�[�^�X�Ǘ��R���|�[�l���g�̊��N���X
	/// </summary>
	public class A_Status : MonoBehaviour {

		[SerializeField] private float _baseValue = 0.0f;
		/// <summary>
		/// �X�e�[�^�X�̊�b��
		/// </summary>
		public float baseValue {
			get { return _baseValue; }
		}

		[SerializeField] private A_CollectionManager _collection;
		/// <summary>
		/// �␳�l�Ǘ��R���|�[�l���g(�ǂݍ��ݐ�p)
		/// </summary>
		public A_CollectionManager collection {
			get { return _collection; }
		}

		private float _value = 0.0f;
		/// <summary>
		/// �␳�l�����݂ł̃X�e�[�^�X�̒l
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
