using GenerallySys.CollectionManageSys;
using GenerallySys.CollectionManageSys.Test;
using System;
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
			get {
				//0�ȉ��̍ۂɎQ�Ƃ�����0��Ԃ��d�l
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
			get { 
				//0�ȉ��̏ꍇ�ɎQ�Ƃ�����0��Ԃ��d�l
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
			}
		}

		/// <summary>
		/// �l���ω������ۂɔ��΂����C�x���g�B������(baseValue,value)�̏��B
		/// </summary>
		public Action<float, float> wasValueChanged;

		private void Start () {
			_collection = GetComponent<A_CollectionManager>();
			_collection.wasChanged += wasChangeCollections;
		}

		/// <summary>
		/// �␳�l�̒l���ω������ۂɌĂяo����āA�ω���̕␳�l���v�Z�����l��value���㏑�����郁�\�b�h
		/// </summary>
		/// <param name="ratioValue"></param>
		/// <param name="fixedValue"></param>
		private void wasChangeCollections (float ratioValue,float fixedValue) {
			_value = (baseValue * ratioValue) + fixedValue;
		}
	}
}
