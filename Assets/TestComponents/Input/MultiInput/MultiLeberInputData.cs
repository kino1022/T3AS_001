using GenerallySys.Definition.Direction;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Test.Input {
	[System.Serializable]
	public class MultiLeberInputData : ScriptableObject {
		/// <summary>
		/// 要求する入力方向は八方向かどうか
		/// </summary>
		public Boolean isEightDirection;
		/// <summary>
		/// 入力に使用するレバーのクラス
		/// </summary>
		public A_Leber lebber;
		/// <summary>
		/// 要求する方向の配列
		/// </summary>
		public List<Direction8> directions8;
		/// <summary>
		/// 要求する方向の配列
		/// </summary>
		public List<Direction4> directions4;
		/// <summary>
		/// 入力間の猶予
		/// </summary>
		public List<float> interval;
	}
}