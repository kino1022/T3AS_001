using System;
using Attribute;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Example.UtilityAI {
    [Serializable]
    public class JudgeData {
        /// <summary>
        /// 
        /// </summary>
        [SerializeReference,SelectableSerializeReference]
        public AJudgeMaterial judgeMaterial;
        /// <summary>
        /// 条件が満たされた際の評価値
        /// </summary>
        public int assessment;
        
        /// <summary>
        /// 評価値ノイズ倍率の最大値
        /// </summary>
        public float maxNoise;
        /// <summary>
        /// 評価値ノイズ倍率の最小値
        /// </summary>
        public float minNoise;
        
        
        /// <summary>
        /// 評価値を取得するメソッド
        /// </summary>
        /// <returns></returns>
        public float GetAssessment() {
            return assessment * Random.Range(minNoise, maxNoise);
        }
    }
}