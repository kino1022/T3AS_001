using System.Collections.Generic;
using Item.Feature;
using UnityEngine;

namespace Item {
    [System.Serializable]
    [CreateAssetMenu(fileName = "NewItem", menuName = "Item/ItemData")]
    public class ItemData : ScriptableObject {
        /// <summary>
        /// アイテムの名前
        /// </summary>
        public string itemName;
        /// <summary>
        /// インベントリ等で表示するアイコン
        /// </summary>
        public Sprite icon;
        
        /// <summary>
        /// アイテムの持つ特徴
        /// </summary>
        [SerializeReference] public List<AItemFeature> features;
    }
}