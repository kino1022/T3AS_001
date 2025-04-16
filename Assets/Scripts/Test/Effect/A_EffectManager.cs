using GenerallySys.Definition;
using System;
using System.Collections.Generic;
using UnityEngine;
using static GenerallySys.Definition.EffectType;

namespace Test.Character.Effect {
	public abstract class A_EffectManager : MonoBehaviour {

		/// <summary>
		/// 現在働いている効果のリスト
		/// </summary>
		private List<A_Effect> _effects;

		/// <summary>
		/// 新しい効果を与えるメソッド
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="constroctour"></param>
		public void CreateNewEffect<T> (Func<T> constroctour) where T : A_Effect {
			T newEffect = constroctour();
			_effects.Add(newEffect);
			newEffect.wasRelease += GetWasRelease;
		}

		/// <summary>
		/// wasReleaseを受け取った際に呼ばれるメソッド
		/// </summary>
		/// <param name="target"></param>
		private void GetWasRelease (A_Effect target) {
			_effects.Remove(target);
			target.wasRelease -= GetWasRelease;
		}

		/// <summary>
		/// バフかデバフか選択した方を全て除外するメソッド
		/// </summary>
		public void RereleaseByEffectType (EffectType type) {
			foreach (var effect in _effects) {
				if (effect.type == type) {
					_effects.Remove(effect);
					effect.wasRelease -= GetWasRelease;
				}
			}
		}
	}
}