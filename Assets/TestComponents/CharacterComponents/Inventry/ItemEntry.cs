using System;
using System.Linq;
using Test.Item;
using UnityEngine;

namespace Test.Character.Inventory {
    /// <summary>
    /// インベントリでアイテムを管理する際の単位。一ブロックがItemEntryインスタンス一個に相当する。
    /// </summary>
    public class ItemEntry {
        /// <summary>
        /// エントリーしているアイテムのデータ
        /// </summary>
        public ItemData item;

        private int _amount = 0;
        /// <summary>
        /// アイテムの数量
        /// </summary>
        public int amount {
            get { return _amount; }
            set { 
                amount = value;
            }
        }

        public ItemEntry (ItemData item, int value) {
            this.item = item;
            this.amount = value;
        }
        /// <summary>
        /// 引数分だけエントリー内のアイテムを加算する
        /// </summary>
        /// <param name="value"></param>
        public void IncreaseItemAmount (int value) {
            amount += value;
            var allowStack = item.GetAllowStack();
            if (allowStack == null) {
                //スタック不可のものに対してのスタック処理がなされたのでエラーを返す
            }
            else if (allowStack.maxValue >= amount) {
                //スタック許容量を超過する量がスタックされたのでエラーを返す
            }
        }
    }
}