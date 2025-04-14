using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GenerallySys.MoveControlSys.GravitiySys {
	/// <summary>
	/// �d�͂̈ړ��ʂ��Ǘ�����}�l�[�W���[�R���|�[�l���g
	/// </summary>
	public class GravityManager : A_MoveValueManager {
		/// <summary>
		/// �����d�͂̑傫��
		/// </summary>
		private float _gravityValue = Physics.gravity.y;

		[SerializeField] private Boolean _enableGravity = true;
		/// <summary>
		/// �d�͂𖳌������邩�ǂ����̐^�U�l�i���[�V�������Ƃ���false�ɂ���j
		/// </summary>
		public Boolean enableGravity {
			get { return _enableGravity; }
			set { _enableGravity = value; }
		}

		private Vector3 _direction = new Vector3(0.0f, 1.0f, 0.0f);
		/// <summary>
		/// �d�͂̓�������
		/// </summary>
		public Vector3 direction {
			get { return _direction; }
			set { _direction = value.normalized; }
		}


		/// <summary>
		/// �d�͕␳�l�̊Ǘ��R���|�[�l���g
		/// </summary>
		private GravityCollectionManager _gravityCollection;

		private CharacterController _controller;

		void Start () {
			//CharacterController�̎擾����
			_controller = GetComponent<CharacterController>();
			if (_controller == null) {
				Debug.Log("CharacterController�̎擾�Ɏ��s���܂���");
			}
			else {
				Debug.Log("characterContorller�̎擾�ɐ������܂���");
			}

			//�␳�l�Ǘ��}�l�[�W���[�̎擾����
			_gravityCollection = GetComponent<GravityCollectionManager>();
			if (_gravityCollection == null) {
				Debug.Log("�d�͕␳�l�Ǘ��}�l�[�W���[�R���|�[�l���g�̎擾�����Ɏ��s���܂���");
			}
			else {
				Debug.Log("�d�͕␳�l�Ǘ��}�l�[�W���[�R���|�[�l���g�̎擾�����ɐ������܂���");
			}
		}

		void Update () {

		}
	}
}