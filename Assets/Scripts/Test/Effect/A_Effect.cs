using GenerallySys.Definition;
using System;
using UnityEngine;
using static GenerallySys.Definition.EffectType;

namespace Test.Character.Effect {
	/// <summary>
	/// 全てのバフの基底クラス
	/// </summary>
	public abstract class A_Effect {
		/// <summary>
		/// 効果がバフかデバフか
		/// </summary>
		public EffectType type;
		/// <summary>
		/// バフが消滅した際に発火されるイベント
		/// </summary>
		public Action<A_Effect> wasRelease;
	}
}