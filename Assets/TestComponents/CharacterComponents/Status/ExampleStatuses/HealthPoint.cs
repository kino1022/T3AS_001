using GenerallySys.CollectionManageSys;
using System;
using UnityEngine;
using UnityEngine.Events;

namespace Test.Character.Status.Examples {
	public class HealthPoint : MonoBehaviour {
		/// <summary>
		/// �񕜗ʂɂ�����␳�l�̊Ǘ��N���X
		/// </summary>
		[SerializeField] public A_CollectionManager healValueCollections;
		/// <summary>
		/// �_���[�W�␳�l�̊Ǘ��N���X
		/// </summary>
		[SerializeField] public A_CollectionManager damageCollections;
		/// <summary>
		/// ��ɂȂ����ۂɔ��΂����UnityEvent
		/// </summary>
		public UnityEvent wasZero;
	}
}