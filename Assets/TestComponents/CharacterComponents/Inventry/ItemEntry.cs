using System;
using Test.Item;
using UnityEngine;

namespace Test.Character.Inventory {
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
    }
}