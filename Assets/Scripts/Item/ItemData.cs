using System.Collections.Generic;
using System.Linq;
using Attribute;
using Common.Utility;
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
        
        /// ストレージ内にある際の重量
        public float weight;
        
        /// <summary>
        /// アイテムの持つ特徴
        /// </summary>
        [SerializeReference,SelectableSerializeReference]
        public List<AItemFeature> features;
        
        /// <summary>
        /// 任意のAItemFeatureを取得するメソッド
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public T GetFeature<T>() where T : AItemFeature {
            return features.Where(x => x.GetType() == typeof(T)).FirstOrDefault() as T;
        }
        
        /// <summary>
        /// 特定のインターフェースをもつAItemFeatureを取得して、その内部のインターフェースを返すメソッド
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public List<T> GetFeaturesHasAnyInterface<T>() {
            var result = new List<T>();
            foreach (var feature in features) {
                result.AddRange(InterfaceUtility.GetAnyInterfaces<T>(feature));
            }
            return result;
        }
    }
}