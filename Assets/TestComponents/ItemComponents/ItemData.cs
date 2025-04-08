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
        /// アイテムがスタック可能な場合はスタック許可コンポーネントを返すメソッド
        /// </summary>
        /// <returns></returns>
        public AllowItemStack GetAllowStack () {
            AllowItemStack allow = (AllowItemStack)features.Where(x => x.GetType() == typeof(AllowItemStack));
            return allow;
        }

        /// <summary>
        /// 任意のA_ItemFeatureを取得するメソッド
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public T GetFeature<T>() where T : A_ItemFeature {
            T feature = (T)features.Where(x => x.GetType() == typeof(T));
            return feature;
        }
    }
}
