using System;
using Test.Character.Definition;
using Test.Character.Skill;
using UnityEngine;
using static Test.Character.Definition.AbilityType;

namespace Test.Character.Ability {
	public abstract class A_Ability {
		/// <summary>
		/// �A�r���e�B�̖��O
		/// </summary>
		[SerializeField] public new string name;
		/// <summary>
		/// �A�r���e�B�̕���
		/// </summary>
		[SerializeField] public AbilityType type;
		/// <summary>
		/// �������`�F�b�N�ɗp����K�����X�L���B
		/// </summary>
		public A_Skill learnFrom;
	}
}