using System;
using System.Collections.Generic;
using System.Text;
using GenerallySys.Definition.Direction;
using UnityEngine;
using UnityEngine.UI;
using static GenerallySys.Definition.Direction.Direction4;
using Vector2 = System.Numerics.Vector2;

namespace GenerallySys.Utility {
	/// <summary>
	/// 抽象化方向を扱うメソッドをまとめたクラス
	/// </summary>
	public static class DirectionUtility {
		
		/// <summary>
		/// 与えられた二次元ベクトルを平面での四方向に抽象化するメソッド
		/// ※与えられた二次元ベクトルの成分が同一だった場合の例外処理が決まっていないのであとで決めておく
		/// </summary>
		/// <param name="vec"></param>
		/// <returns></returns>
		public static Direction4 ChangeVector2ForDireciton4(UnityEngine.Vector2 vec,float threshold = 0.1f) {
			if (vec.magnitude < threshold) return N4;
			vec.Normalize();
			float angle = Mathf.Atan2(vec.y, vec.x) * Mathf.Rad2Deg;
			if (angle < 0) angle += 360;

			if (angle >= 315.0f || angle < 45.0f) return R4;
			else if (angle < 135.0f) return F4;
			else if (angle < 225.0f) return L4;
			else  return B4;
		}
		
		/// <summary>
		/// 与えられた二次元ベクトルを平面での八方向に抽象化するメソッド
		/// </summary>
		/// <param name="vec"></param>
		/// <returns></returns>
		public static Direction8 ChangeVector2ForDireciton8(UnityEngine.Vector2 vec,float threshold = 0.1f) {
			if (vec.magnitude < threshold) return Direction8.N8;
			vec.Normalize();
			float angle = Mathf.Atan2(vec.y, vec.x) * Mathf.Rad2Deg;
			if (angle < 0) angle += 360;

			if (angle >= 337.5f || angle < 22.5f) return Direction8.R8;
			else if (angle < 67.5f) return Direction8.FR8;
			else if (angle < 112.5f) return Direction8.F8;
			else if (angle < 157.5f) return Direction8.FL8;
			else if (angle < 202.5f) return Direction8.L8;
			else if (angle < 247.5f) return Direction8.BL8;
			else if (angle < 292.5f) return Direction8.B8;
			else return Direction8.BR8;
		}

		public static UnityEngine.Vector2 ChangeDirection2Vector2(Direction2H horizontal,Direction2V vertical) {
			UnityEngine.Vector2 vec = new UnityEngine.Vector2();
			if (horizontal == Direction2H.R2H) vec.x = 1.0f;
			else if (horizontal == Direction2H.L2H) vec.x = -1.0f;
			
			if (vertical == Direction2V.F2V) vec.y = 1.0f;
			else if (vertical == Direction2V.B2V) vec.y = -1.0f;
			return vec;
		}
	}
}
