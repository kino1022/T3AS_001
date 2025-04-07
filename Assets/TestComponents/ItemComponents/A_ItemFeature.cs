using System;
using UnityEngine;

namespace Test.Item {
	[System.Serializable]
	/// <summary>
	/// スタック不可などのアイテムの特徴の基底クラス(インターフェースだとエディタでの操作が出来ないので抽象化しました)
	/// </summary>
	public abstract class A_ItemFeature : ScriptableObject {

	}
}