using UnityEngine;
using System;
using System.Collections.Generic;
using Test.Item;
using System.Linq;

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
			set {
				_wigth = value;
				maxEntry = _wigth * _higher;
			}
		}

		[SerializeField] private int _higher = 13;
		/// <summary>
		///　インベントリの高さ
		/// </summary>
		public int higher {
			get { return _higher; }
			set { 
				_higher = value;
				maxEntry = _higher * _wigth;
			}
		}
		/// <summary>
		/// インベントリに入るエントリの限界数
		/// </summary>
		public int maxEntry = 0;

		public List<ItemEntry> items = new List<ItemEntry>();

        private void Awake() {
            maxEntry = wigth * higher;
            //整合性検査
			if (!CheckIntegrityInventory()) {
				Debug.LogWarning("インベントリコンポーネントの初期化で以上が生じています");
			}
        }

        /// <summary>
        /// ItemEntryの新規生成処理を行うメソッド
        /// </summary>
        /// <param name="item">生成するエントリのアイテムデータ</param>
        /// <param name="amount">生成するエントリのアイテム量</param>
        private void CreateNewEntry (ItemData item,int amount) {
			AllowItemStack allow = item.GetFeature<AllowItemStack>();
			if (allow != null && allow.maxValue >= amount) {
				//考慮すべき例外と加算フローがはっきりした段階で着手するべきである。
				//今後の開発に遺恨を残すべきではない。
			}
		}
		/// <summary>
		/// インベントリの整合性チェックメソッド
		/// </summary>
		/// <returns></returns>
		private Boolean CheckIntegrityInventory () {
			Boolean isIntegrity = true;
			if (items.Count > maxEntry) {
				isIntegrity = false;
				Debug.Log("インベントリ容量を超過するアイテムのエントリがあります。");
			}
			if (maxEntry <= 0) {
				isIntegrity = false;
				if (_higher <= 0) Debug.Log("インベントリの高さが0以下のためインベントリ容量が不整合です");
				else if (_wigth <= 0) Debug.Log("インベントリの横幅が0以下のためインベントリ容量が不整合です");
				else Debug.Log("インベントリ容量の正常化が行われていないようです。コードの見直しを行なってください");
			}
			return isIntegrity;
		}
	}
}