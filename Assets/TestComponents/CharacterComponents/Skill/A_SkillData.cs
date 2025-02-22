using System;
using System.Collections.Generic;
using UnityEngine;

namespace Test.Character.Skill {
	[System.Serializable]
	[CreateAssetMenu(fileName = "SkillData",menuName = "スキルデータ")]

	/// <summary>
	/// 
	/// </summary>
	public class SkillData : ScriptableObject {
		/// <summary>
		/// 習得アビリティと習得熟練度を記したデータの配列
		/// </summary>
		[SerializeField] public List<AcquireAbility> abilitys;
		/// <summary>
		/// スキルの最大レベル
		/// </summary>
		[SerializeField] public int maxLevel;
	}
}