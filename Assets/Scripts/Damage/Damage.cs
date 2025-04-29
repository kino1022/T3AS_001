using System;
using System.Collections.Generic;
using Attribute;
using Damage.Features;
using Element;
using UnityEngine;

namespace Damage {
    /// <summary>
    /// 属性ごとのダメージを管理するクラス
    /// </summary>
    [Serializable]
    public class Damage {
        /// <summary>
        /// ダメージ量
        /// </summary>
        public float damageValue;
        /// <summary>
        /// 属性分類
        /// </summary>
        [SerializeReference,SelectableSerializeReference]
        public AElement element;
        
        /// <summary>
        /// ダメージに持たせる特徴とか
        /// </summary>
        [SerializeReference,SelectableSerializeReference]
        public List<ADamageFeature> features;

        public Damage(float damageValue, AElement element) {
            this.damageValue = damageValue;
            this.element = element;
        }
    }
}