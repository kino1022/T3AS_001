using System.Collections.Generic;
using Element;

namespace Damage {
    /// <summary>
    /// 属性ごとのダメージを管理するクラス
    /// </summary>
    public class Damage {
        /// <summary>
        /// ダメージ量
        /// </summary>
        public float damageValue;
        /// <summary>
        /// 属性分類
        /// </summary>
        public AElement element;
        
        public List<ADamageFeature> features = new List<ADamageFeature>();

        public Damage(float damageValue, AElement element) {
            this.damageValue = damageValue;
            this.element = element;
        }
    }
}