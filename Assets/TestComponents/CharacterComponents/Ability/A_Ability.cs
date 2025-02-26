using System;
using Test.Character.Definition;
using Test.Character.Skill;
using UnityEngine;
using static Test.Character.Definition.AbilityType;

namespace Test.Character.Ability {
	public abstract class A_Ability {
		/// <summary>
		/// アビリティの名前
		/// </summary>
		[SerializeField] public new string name;
		/// <summary>
		/// アビリティの分類
		/// </summary>
		[SerializeField] public AbilityType type;
		/// <summary>
		/// 整合性チェックに用いる習得元スキル。
		/// </summary>
		public A_Skill learnFrom;
	}
}