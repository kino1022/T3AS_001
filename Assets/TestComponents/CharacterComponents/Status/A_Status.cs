using GenerallySys.CollectionManageSys;
using System;
using UnityEngine;

namespace Test.Character.Status {
	/// <summary>
	/// �S�ẴX�e�[�^�X�̊��N���X
	/// </summary>
	public abstract class A_Status : MonoBehaviour {
		/// <summary>
		/// �X�e�[�^�X�̖��O
		/// </summary>
		[SerializeField] private string _statusName;

		private float _baseValue;
		/// <summary>
		/// �␳�O�̊�b�l
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
		/// �␳�l���݂ł̍ŏI�I�Ȓl
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
		/// ���̃X�e�[�^�X�̎���ő�l
		/// </summary>
		public float maxValue {
			get { return _maxValue; } 
			set { _maxValue = value; }
		}

		[SerializeField] private float _minValue;
		/// <summary>
		/// ���̃X�e�[�^�X�̎���ŏ��l
		/// </summary>
		public float minValue {
			get { return _minValue; }
			set { _minValue = value; }
		}

		/// <summary>
		/// �X�e�[�^�X�␳�l�̊Ǘ��N���X
		/// </summary>
		[SerializeField] public A_CollectionManager statusCollection;


		/// <summary>
		/// �l���ω����ꂽ�ۂɔ��΂����C�x���g
		/// </summary>
		public Action wasValueChanged;

		private void Start () {

			if (statusCollection != null) {
				Debug.Log($"{_statusName}�̕␳�l�}�l�[�W���[���A�^�b�`����Ă��܂���I");
			}
			else {
				statusCollection.wasChanged += CollectionValueWasChanged;
			}

			WasStartColled();
		}

		/// <summary>
		/// �␳�l�̕ω��ɂ���ČĂяo�����_value��␳�l���݂̒l�ōČv�Z����
		/// </summary>
		/// <param name="ratio"></param>
		/// <param name="fix"></param>
		private void CollectionValueWasChanged (float ratio,float fix) {
			value = _baseValue * ratio + fix;
		}

		/// <summary>
		/// Start���\�b�h�̍Ō�ɌĂяo����郁�\�b�h
		/// </summary>
		protected virtual void WasStartColled () {

		}
	}
}