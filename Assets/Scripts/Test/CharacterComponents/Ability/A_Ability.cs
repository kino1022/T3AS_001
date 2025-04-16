using System;
using Test.Character.Definition;
using Test.Character.Skill;
using UnityEngine;
using static Test.Character.Definition.AbilityType;

namespace Test.Character.Ability {
	public abstract class A_Ability {
		[SerializeField] public AbilityData data;
	}
}