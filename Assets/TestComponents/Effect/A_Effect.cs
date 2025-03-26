using GenerallySys.Definition;
using System;
using UnityEngine;
using static GenerallySys.Definition.EffectType;

namespace Test.Character.Effect {
	/// <summary>
	/// �S�Ẵo�t�̊��N���X
	/// </summary>
	public abstract class A_Effect {
		/// <summary>
		/// ���ʂ��o�t���f�o�t��
		/// </summary>
		public EffectType type;
		/// <summary>
		/// �o�t�����ł����ۂɔ��΂����C�x���g
		/// </summary>
		public Action<A_Effect> wasRelease;
	}
}