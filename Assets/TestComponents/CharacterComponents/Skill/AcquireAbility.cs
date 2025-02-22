using System;
using UnityEngine;
using Test.Character.Ability;

namespace Test.Character.Skill {
	[System.Serializable]
	[CreateAssetMenu(fileName = "AcquireAbility",menuName = "�K���A�r���e�B")]
	public class AcquireAbility : ScriptableObject {
		/// <summary>
		/// �K������A�r���e�B
		/// </summary>
		public A_Ability ability;
		/// <summary>
		/// �K������X�L�����x��
		/// </summary>
		public int skillLevel;
	}
}