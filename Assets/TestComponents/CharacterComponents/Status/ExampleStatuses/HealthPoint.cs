using GenerallySys.CollectionManageSys;
using System;
using UnityEngine;
using UnityEngine.Events;

namespace Test.Character.Status.Examples {
	public class HealthPoint : MonoBehaviour {
		/// <summary>
		/// 回復量にかかる補正値の管理クラス
		/// </summary>
		[SerializeField] public A_CollectionManager healValueCollections;
		/// <summary>
		/// ダメージ補正値の管理クラス
		/// </summary>
		[SerializeField] public A_CollectionManager damageCollections;
		/// <summary>
		/// 零になった際に発火されるUnityEvent
		/// </summary>
		public UnityEvent wasZero;
	}
}