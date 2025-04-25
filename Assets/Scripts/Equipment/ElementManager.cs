using System;
using System.Collections.Generic;
using CustomAbility;
using Element;
using UnityEngine;

namespace Equipment {
    /// <summary>
    /// 武器の持つ属性を管理するコンポーネント
    /// </summary>
    public class ElementManager : MonoBehaviour {
        /// <summary>
        /// 武器に付与する属性
        /// </summary>
        [SerializeField] public List<WeaponAbility> elements;

        private void Start() {
            if (elements.Count == 0) {
                Debug.LogWarning($"{this.gameObject.name}:属性が一つも定義されていません");
            }
        }
    }
}