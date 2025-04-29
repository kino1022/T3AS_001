using System.Collections.Generic;
using Attribute;
using UnityEngine;

namespace Example.UtilityAI {
    /// <summary>
    /// 最終的な条件判断の判断要素
    /// </summary>
    [System.Serializable]
    public abstract class ALustJudgeMaterial : AJudgeMaterial {
        /// <summary>
        /// 最終判断を下すにあたって前提になる条件
        /// </summary>
        [SerializeReference,SelectableSerializeReference]
        private List<AJudgeMaterial> materials;
    
        
        
        /// <summary>
        /// 子条件が全てtrueかどうかを返すメソッド
        /// </summary>
        /// <returns></returns>
        private bool GetIsChildTermsCleared() {
            foreach (var material in materials) {
                //子条件のうち一つでもfalseならfalseを返す
                if (!material.GetIsTermCleared()) return false;
            }
            return true;
        }
    }
}