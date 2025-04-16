using System;
using UnityEngine;
using Test.Character.Ability;

namespace Test.Character.Skill {
	[System.Serializable]
	[CreateAssetMenu(fileName = "AcquireAbility",menuName = "習得アビリティ")]
	public class AcquireAbility : ScriptableObject {
		/// <summary>
		/// 習得するアビリティ
		/// </summary>
		public A_Ability ability;
		/// <summary>
		/// 習得するスキルレベル
		/// </summary>
		public int skillLevel;
	}
}