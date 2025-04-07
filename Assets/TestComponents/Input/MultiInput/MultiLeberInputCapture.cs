using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Cysharp.Threading.Tasks;
using GenerallySys.Definition.Direction;
using UnityEditor.Playables;
using UnityEngine;
using UnityEngine.Events;
using static UnityEditor.Playables.Utility;

namespace Test.Input {
	/// <summary>
	/// スティックや方向キーの特定方向への連続入力を検知するコンポーネント
	/// </summary>
	public class MultiLeberInputCapture : MonoBehaviour {
		/// <summary>
		/// 連続入力条件等のデータ
		/// </summary>
		[SerializeField] private MultiLeberInputData _data;
		/// <summary>
		/// 入力成立時に発火するイベント
		/// </summary>
		[SerializeField] public UnityEvent couseEvent;

		void Start() {
			if (_data.isEightDirection) {
				_data.lebber.changeDirection4.AddListener(StartInputCheckDirection4);
			}
		}

		void StartInputCheckDirection4 (Direction4 direction) {
			if (direction == _data.directions4[0]) {
				var directionsData = _data.directions4;
				directionsData.RemoveAt(0);

				InputCaptureDirection4(directionsData,_data.interval,this.GetCancellationTokenOnDestroy()).Forget();
			}
		}

		async UniTask InputCaptureDirection4 (List<Direction4> directions,List<float> intervals,CancellationToken token) {
			try{
				Boolean succese = true;
				for (int i = 0; i < directions.Count; i++) {
					//waitForUnityEventが使えないから専用のタスクを組む必要がある！！
					var wasInput = await WaitForSpecificDirection4(directions[i],intervals[i]);
					if (!wasInput) {
						succese = false;
						break;
					}
				}

				if(succese) {
					couseEvent?.Invoke();
				}
			}
			catch (OperationCanceledException) {

			}
			finally {

			}
		}
		/// <summary>
		/// 特定レバーの特定方向への入力を待機し、時間以内に特定方向への入力が為されない場合はfalseを返すタスク
		/// </summary>
		/// <param name="direction">要求する方向</param>
		/// <param name="grace">入力猶予</param>
		/// <returns></returns>
		async UniTask<Boolean> WaitForSpecificDirection4 (Direction4 direction,float grace) {
			var tcs = new UniTaskCompletionSource();

			_data.lebber.changeDirection4.AddListener(OnTrigger);

			var CompletedTask = await UniTask.WhenAny(
				tcs.Task,
				UniTask.Delay(TimeSpan.FromSeconds(grace))
			);

			if (CompletedTask == 1) return true;
			else return false;

			void OnTrigger (Direction4 input) {
				if (input == direction) {
					tcs.TrySetResult();
					_data.lebber.changeDirection4.RemoveListener(OnTrigger);
				}
			}
		}
	}
}
