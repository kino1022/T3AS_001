using System;
using System.Collections.Generic;
using Attribute;
using General.Correction.Definition;
using UnityEngine;

namespace General.Correction.CorrectionLists {
    /// <summary>
    /// 補正値のリストの基底クラス
    /// </summary>
    [Serializable]
    public class ACorrectionList {
        /// <summary>
        /// 補正値の合計値
        /// </summary>
        [SerializeField] public float totalValue;
        
        /// <summary>
        /// 管理する補正値の分類
        /// </summary>
        [SerializeReference,SelectableSerializeReference]
        public CorrectionType type;
        
        /// <summary>
        /// 管理している補正値のリスト
        /// </summary>
        [SerializeField] public List<Correction> corrections = new List<Correction>();
        
        /// <summary>
        /// 補正値の値が変化した際に発火されるイベント
        /// </summary>
        public Action TotalValueChangeEvent;
        
        ///補正値をリストに加えるメソッド
        public void AddCorrection(Correction correction) {
            corrections.Add(correction);
            correction.CorrectionRemoveEvent += OnRemoveCorrection;
            TotalValueChangeEvent?.Invoke();
        }
        
        ///補正値から除外通知が来た際に実行されるメソッド
        protected virtual void OnRemoveCorrection(Correction correction) {
            corrections.Remove(correction);
            TotalValueChangeEvent?.Invoke();
        }
    }
}