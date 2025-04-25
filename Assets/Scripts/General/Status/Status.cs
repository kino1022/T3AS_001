using System;
using General.Correction;
using General.Status.Interface;
using UnityEditor;
using UnityEngine;

namespace General.Status {
    /// <summary>
    /// ステータスの管理を行うクラス
    /// </summary>
    public class Status : MonoBehaviour ,ISetUpStatusFromData {
        /// <summary>
        /// ステータスの元々の値
        /// </summary>
        [SerializeField] public BaseValue baseValue;
        
        /// <summary>
        /// 補正後の最終的な値
        /// </summary>
        [SerializeField] public CorrectionedValue value;
        
        /// <summary>
        /// 補正値を管理するクラス
        /// </summary>
        [SerializeField] public CorrectionManager Correction;
        
        /// <summary>
        /// ステータスの値が参照された際に負数を返すことを許容するか
        /// </summary>
        [SerializeField] private bool allowMinusVlaue;
        
        /// <summary>
        /// ステータスの値をデータで初期化する際に使用するデータクラス
        /// </summary>
        [SerializeField] private StatusData statusData;
        


        public void Start() {
            SetUpStatusAttribute();
            if (statusData != null) SetUpStatusFromData(statusData);
            if (Correction != null) Correction.CorrectionValueChangeEvent += OnCorrectionValueChange;
            OnStart();
        }
        
        /// <summary>
        /// 指定した値を各フィールドに対して加算するメソッド：
        /// </summary>
        /// <param name="amount"></param>
        public void AddStatusValue(float amount) {
            baseValue.Value += amount;
            value.Value += amount;
        }
        
        /// <summary>
        /// ステータス管理クラスのセットアップを行うメソッド
        /// </summary>
        private void SetUpStatusAttribute() {
            baseValue.AllowMinusVlaue = allowMinusVlaue;
            value.AllowMinusVlaue = allowMinusVlaue;
        }
        
        /// <summary>
        /// ステータスの値の初期化を行うメソッド
        /// </summary>
        private void SetUpStatusValue() {
            baseValue.Value = value.Value;
        }
        
        public void SetUpStatusFromData(StatusData statusData) {
            this.allowMinusVlaue = statusData.allowMinusVlaue;
        }
        
        /// <summary>
        /// 補正値の再計算をして代入するメソッド
        /// </summary>
        protected virtual void OnCorrectionValueChange() {
            value.Value = Correction.CalculateCorrectionedValue(value.Value);
        }
        
        protected virtual void OnStart () {}
    }
}