using System;
using UnityEngine;
using GenerallySys.CollectionManageSys;
using UnityEngine.Events;

namespace Test.Character.Status {
	public class Stamina : MonoBehaviour {
		/// <summary>
		///	�X�^�~�i����ʂɑ΂��Ă�����␳�l�̊Ǘ��}�l�[�W���[
		/// </summary>
		[SerializeField] public A_CollectionManager consumeManager;
		/// <summary>
		/// �ő�X�^�~�i�̊Ǘ��N���X
		/// </summary>
		private MaxStamina maxStamina;
		/// <summary>
		///	�X�^�~�i��0�ɂȂ����ۂɔ��΂����C�x���g
		/// </summary>
		public UnityEvent wasZero;

		private void Start () {
			maxStamina = this.GetComponent<MaxStamina>();
			if (maxStamina == null) {
				Debug.Log("�ő�X�^�~�i�̊Ǘ��R���|�[�l���g�̎擾�Ɏ��s���܂���");
			}
		}
	}
}