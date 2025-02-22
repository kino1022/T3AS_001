using System;
using System.Collections.Generic;
using UnityEngine;

namespace Test.Character.Status {
	/// <summary>
	/// A_BaseStatusの変化を受けて変化するステータスの基底クラス
	/// </summary>
	public abstract class A_DevStatus : A_Status {
		/// <summary>
		/// 影響を与えるステータス
		/// </summary>
		[SerializeField] private List<A_Status> _baseStatuses;
	}
}