using GenerallySys.CollectionManageSys;
using System;
using UnityEngine;

namespace Test.Character.Status.Examples {
	public class HealthPoint : A_DevStatus {
		/// <summary>
		/// 回復量にかかる補正値の管理クラス
		/// </summary>
		[SerializeField] public A_CollectionManager healValueCollection;
	}
}