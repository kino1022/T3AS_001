using Cysharp.Threading.Tasks;
using System;
using System.Threading;
using UnityEngine;
using static GenerallySys.Definition.EffectType;
namespace Test.Character.Effect.Test {
	/// <summary>
	/// テスト用のダミーデバフ(テスト例として耐久値暫時減少をアタッチ)
	/// </summary>
	public class DummyDebuffEffect : A_Effect {

		private CancellationTokenSource cts = new CancellationTokenSource();

		public DummyDebuffEffect (int decreaseValue,float decreaseSpan) {
			this.type = Minus;

			CancellationToken token = cts.Token;

			DecreaseHPPerTime(cts.Token, decreaseValue, decreaseSpan);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="token"></param>
		/// <param name="decreaseValue"></param>
		/// <param name="decreaseSpan"></param>
		/// <returns></returns>
		private async UniTaskVoid DecreaseHPPerTime (CancellationToken token,int decreaseValue,float decreaseSpan) {

		}
	}
}