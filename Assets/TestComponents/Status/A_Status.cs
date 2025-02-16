using GenerallySys.CollectionManageSys;
using GenerallySys.CollectionManageSys.Test;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnityEngine;

namespace Test.Status {
	/// <summary>
	/// �X�e�[�^�X�Ǘ��R���|�[�l���g�̊��N���X
	/// </summary>
	public class A_Status : MonoBehaviour {

		/// <summary>
		/// �X�e�[�^�X�̖��O
		/// </summary>
		[SerializeField] private string _statusName;

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
			_collection.wasChanged += wasChangeCollections;
		}

		private void Update () {
			
		}

		/// <summary>
		/// �␳�l�̒l���ω������ۂɌĂяo����āA�ω���̕␳�l���v�Z�����l��value���㏑�����郁�\�b�h
		/// </summary>
		/// <param name="ratioValue"></param>
		/// <param name="fixedValue"></param>
		private void wasChangeCollections (float ratioValue,float fixedValue) {
			_value = (baseValue * ratioValue) + fixedValue;
		}

		/// <summary>
		/// �X�e�[�^�X�̌��̒l��ω����郁�\�b�h
		/// </summary>
		/// <param name="changeValue">�ω���</param>
		public void ChangeBaseValue (float changeValue) {
			Debug.Log($"{changeValue}���A{_statusName}�̒l��ω������܂�");
			_baseValue += changeValue;
		}

		
	}
}
