using System;
using System.Collections.Generic;
using Attribute;
using General.Correction.Definition;
using UnityEngine;

namespace General.Correction {
    /// <summary>
    /// CorrectionTypeごとに補正値を管理するクラス
    /// </summary>
    [System.Serializable]
    public class CorrectionList : ICorrectionExecuter {
        /// <summary>
        /// 管理する補正値の分類
        /// </summary>
        [SerializeReference,SelectableSerializeReference]
        public CorrectionType Type;
        
        /// <summary>
        /// 管理している補正値のリスト
        /// </summary>
        private List<Correction> corrections;
        
        private float _totalValue;

        /// <summary>
        /// 管理している補正値の合計値
        /// </summary>
        public float totalValue {
            get { return _totalValue; }
            set {
                _totalValue = value;
                OnChangeTotalValue(_totalValue);
                ChangeTotalValueEvent?.Invoke();
            }
        }

        public Action ChangeTotalValueEvent;


        public CorrectionList(CorrectionType type) {
            this.Type = type;
            Initialize();
        }
        
        /// <summary>
        /// 管理している補正値の合計値を計算するメソッド
        /// </summary>
        /// <returns></returns>
        private float CalculateTotalValue() {
            var newValue = 0f;
            foreach (var correction in corrections) {
                newValue += correction.value;
            }
            return newValue;
        }

        public void AddCorrection(Correction correction) {
            if (correction.Type == Type) {
                Debug.LogWarning("管理している補正値のタイプとは異なる補正値が追加されようとしています");
                return;
            }
            corrections.Add(correction);
            totalValue = CalculateTotalValue();
            correction.CorrectionRemoveEvent += OnCorrectionRemove;
        }
        
        /// <summary>
        /// 管理している補正値と補正値分類に基づいて補正後の値を計算するメソッド
        /// </summary>
        /// <param name="baseValue"></param>
        /// <returns></returns>
        public float ExecuteCorrection(float baseValue) {
            float value = baseValue;
            return CalculateTotalValue();
        }
        
        private void OnCorrectionRemove(Correction correction) {
            corrections.Remove(correction);
            totalValue -= correction.value;
            OnPostCorrectionRemove(correction);
        }
        
        protected virtual void OnPostCorrectionRemove (Correction correction) {}
        
        protected virtual void OnChangeTotalValue(float newValue) {}

        private void Initialize() {
            OnInitialize();
        }

        protected virtual void OnInitialize() { }
    }
}