using System;
using UnityEngine;
using GenerallySys.CollectionManageSys;
using UnityEngine.Events;

namespace Test.Character.Status {
	public class Stamina : MonoBehaviour {
		/// <summary>
		///	スタミナ消費量に対してかかる補正値の管理マネージャー
		/// </summary>
		[SerializeField] public A_CollectionManager consumeManager;
		/// <summary>
		/// 最大スタミナの管理クラス
		/// </summary>
		private MaxStamina maxStamina;
		/// <summary>
		///	スタミナが0になった際に発火されるイベント
		/// </summary>
		public UnityEvent wasZero;

		private void Start () {
			maxStamina = this.GetComponent<MaxStamina>();
			if (maxStamina == null) {
				Debug.Log("最大スタミナの管理コンポーネントの取得に失敗しました");
			}
		}
	}
}