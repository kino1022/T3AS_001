using System;
using System.Collections.Generic;

namespace Damage {
    /// <summary>
    /// 一度に発生したDamageClassをまとめるクラス、
    /// </summary>
    [Serializable]
    public class TotalDamage {
        /// <summary>
        /// 発生した全てのダメージクラス
        /// </summary>
        public List<Damage> Damages = new List<Damage>();
    }
}