using UnityEngine;
using System;
using System.Collections.Generic;
using Test.Item;

namespace Test.Character.Inventory {
	/// <summary>
	/// インベントリの基底クラス
	/// </summary>
	public abstract class A_Inventory : MonoBehaviour {

		[SerializeField] private int _wigth = 10;
		/// <summary>
		/// インベントリの横幅
		/// </summary>
		public int wigth {
			get { return _wigth; }
			set { _wigth = value; }
		}

		[SerializeField] private int _higher = 13;
		/// <summary>
		///　インベントリの高さ
		/// </summary>
		public int higher {
			get { return _higher; }
			set { 
				_higher = value;
			}
		}

		public List<ItemEntry> items = new List<ItemEntry>();

		public void AddNewItem (ItemEntry item) {
			if (items.Count >= wigth * higher) {
				//アイテムドロップ処理を呼び出す
			}
			else {
				items.Add (item);
			}
		}
	}

}