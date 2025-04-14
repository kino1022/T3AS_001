using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;

namespace Test.Item {
    [System.Serializable]
    [CreateAssetMenu(fileName = "NewItem",menuName ="Item/itemData")]
    public class ItemData : ScriptableObject {
        /// <summary>
        /// アイテムの名前
        /// </summary>
        public string itemName;
        /// <summary>
        /// インベントリ内で表示されるアイテムの画像
        /// </summary>
        public Image icon;
        /// <summary>
        /// アイテム一つ当たりの重量
        /// </summary>
        public float weight = 0.01f;
        /// <summary>
        /// アイテムに持たせる特徴
        /// </summary>
        public List<A_ItemFeature> features;

        /// <summary>
        /// 任意のA_ItemFeatureを取得するメソッド
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public T GetFeature<T>() where T : A_ItemFeature {
            T feature = (T)features.Where(x => x.GetType() == typeof(T));
            return feature;
        }
        /// <summary>
        /// 任意のA_ItemFeatureを付与するメソッド
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public void GrantFeature<T>() where T : A_ItemFeature {
            features.Add((T)Activator.CreateInstance(typeof(T)));
        }
    }
}
