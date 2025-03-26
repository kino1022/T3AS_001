using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.Events;

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
				
			}
		}
	}
}
