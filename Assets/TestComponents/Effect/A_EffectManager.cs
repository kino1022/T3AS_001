using GenerallySys.Definition;
using System;
using System.Collections.Generic;
using UnityEngine;
using static GenerallySys.Definition.EffectType;

namespace Test.Character.Effect {
	public abstract class A_EffectManager : MonoBehaviour {

		/// <summary>
		/// ���ݓ����Ă�����ʂ̃��X�g
		/// </summary>
		private List<A_Effect> _effects;

		/// <summary>
		/// �V�������ʂ�^���郁�\�b�h
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="constroctour"></param>
		public void CreateNewEffect<T> (Func<T> constroctour) where T : A_Effect {
			T newEffect = constroctour();
			_effects.Add(newEffect);
			newEffect.wasRelease += GetWasRelease;
		}

		/// <summary>
		/// wasRelease���󂯎�����ۂɌĂ΂�郁�\�b�h
		/// </summary>
		/// <param name="target"></param>
		private void GetWasRelease (A_Effect target) {
			_effects.Remove(target);
			target.wasRelease -= GetWasRelease;
		}

		/// <summary>
		/// �o�t���f�o�t���I����������S�ď��O���郁�\�b�h
		/// </summary>
		public void RereleaseEffectType (EffectType type) {
			foreach (var effect in _effects) {
				if (effect.type == type) {
					_effects.Remove(effect);
					effect.wasRelease -= GetWasRelease;
				}
			}
		}
	}
}