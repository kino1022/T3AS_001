using System;
using System.Collections.Generic;
using UnityEngine;

namespace Test.Character.Status {
	/// <summary>
	/// A_BaseStatus�̕ω����󂯂ĕω�����X�e�[�^�X�̊��N���X
	/// </summary>
	public abstract class A_DevStatus : A_Status {
		/// <summary>
		/// �e����^����X�e�[�^�X
		/// </summary>
		[SerializeField] private List<A_Status> _baseStatuses;
	}
}