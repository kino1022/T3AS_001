using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Test.Item {
    [System.Serializable]
    [CreateAssetMenu(fileName = "NewItem",menuName ="Item/itemData")]
    public class ItemData : ScriptableObject {
        /// <summary>
        /// �A�C�e���̖��O
        /// </summary>
        public string ItemName;
        /// <summary>
        /// �ő�X�^�b�N��
        /// </summary>
        public int maxStack = 1;
    }
}
