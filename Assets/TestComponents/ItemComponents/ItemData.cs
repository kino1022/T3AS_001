using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Test.Item {
    [CreateAssetMenu(fileName = "NewItem",menuName ="Item/itemData")]
    public class ItemData : ScriptableObject {
        /// <summary>
        /// �A�C�e���̖��O
        /// </summary>
        public string ItemName;
    }
}
