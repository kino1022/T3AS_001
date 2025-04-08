using System;
using UnityEngine;

namespace Test.Item {
	/// <summary>
	/// スタック不可などのアイテムの特徴の基底クラス(インターフェースだとエディタでの操作が出来ないので抽象化しました)
	/// </summary>
	[System.Serializable]
	public abstract class A_ItemFeature : ScriptableObject {
		
	}
}