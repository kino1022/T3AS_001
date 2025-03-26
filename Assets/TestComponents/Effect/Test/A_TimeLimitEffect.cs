using Cysharp.Threading.Tasks;
using System;
using System.Threading;
using UnityEngine;

namespace Test.Character.Effect.Test {
	public abstract class A_TimeLimitEffect : A_Effect {
		/// <summary>
		/// 持続する時間
		/// </summary>
		private float _duration;

		private float _timer;
		/// <summary>
		/// 残り時間
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
		/// 継承先で用いるコンストラクタで呼び出される初期化メソッド
		/// </summary>
		protected virtual void WasEffectInstanced () {

		}
		/// <summary>
		/// 効果時間延長メソッド
		/// </summary>
		/// <param name="value"></param>
		private void ExtentionDuration (float value) {
			timer += value;
			_duration += value;
		}

		/// <summary>
		/// エフェクト消滅のタイマー処理
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
				this.wasRelease?.Invoke(this);//エフェクト消滅イベントの発火処理
			}
		}
	}
}