using Cysharp.Threading.Tasks;
using System;
using System.Threading;
using UnityEngine;

namespace Test.Character.Effect.Test {
	public abstract class A_TimeLimitEffect : A_Effect {
		/// <summary>
		/// �������鎞��
		/// </summary>
		private float _duration;

		private float _timer;
		/// <summary>
		/// �c�莞��
		/// </summary>
		public float timer {
			get { return _timer; } 
			set { _timer = value; }
		}

		public A_TimeLimitEffect (float duration,CancellationToken taskToken) {
			_duration = duration;
			timer = duration;

			WasEffectInstanced();
		}
		/// <summary>
		/// �p����ŗp����R���X�g���N�^�ŌĂяo����鏉�������\�b�h
		/// </summary>
		protected virtual void WasEffectInstanced () {

		}
		/// <summary>
		/// ���ʎ��ԉ������\�b�h
		/// </summary>
		/// <param name="value"></param>
		private void ExtentionDuration (float value) {
			timer += value;
			_duration += value;
		}

		/// <summary>
		/// �G�t�F�N�g���ł̃^�C�}�[����
		/// </summary>
		/// <param name="token"></param>
		/// <returns></returns>
		async private UniTask EffectLimitTimer (CancellationToken token) {
			try {
				while (timer <= 0.0f || !token.IsCancellationRequested) {
					await UniTask.Delay(TimeSpan.FromSeconds(0.01f));
					timer -= 0.01f;
				}
			}
			catch (OperationCanceledException) {
				
			}
			finally {
				this.wasRelease?.Invoke(this);//�G�t�F�N�g���ŃC�x���g�̔��Ώ���
			}
		}
	}
}