using System;
using System.Collections.Generic;
using UnityEngine;

namespace Test.Character.Skill {
	[System.Serializable]
	[CreateAssetMenu(fileName = "SkillData",menuName = "�X�L���f�[�^")]
	/// <summary>
	/// �X�L���̃f�[�^
	/// </summary>
	public class SkillData : ScriptableObject {
		
		/// <summary>
		/// �K���A�r���e�B�ƏK���n���x���L�����f�[�^�̔z��
		/// </summary>
		[SerializeField] public List<AcquireAbility> abilitys;
		/// <summary>
		/// �X�L���̍ő僌�x��
		/// </summary>
		[SerializeField] public int maxLevel;
	}
}