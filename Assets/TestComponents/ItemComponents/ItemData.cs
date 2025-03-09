using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Test.Item {
    [System.Serializable]
    [CreateAssetMenu(fileName = "NewItem",menuName ="Item/itemData")]
    public class ItemData : ScriptableObject {
        /// <summary>
        /// アイテムの名前
        /// </summary>
        public string ItemName;
        /// <summary>
        /// 最大スタック数
        /// </summary>
        public int maxStack = 1;
    }
}
