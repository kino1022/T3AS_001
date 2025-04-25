using System;
using UnityEngine;

namespace General.Status {
    /// <summary>
    /// ステータスの元々の値を管理するクラス
    /// </summary>
    [System.Serializable]
    public class BaseValue {
        
        [SerializeField] private float value;
        /// <summary>
        /// ステータスの元々の値
        /// </summary>
        public float Value {
            get { return value < 0.0f && !AllowMinusVlaue ? 0.0f : value; }
            set {
                value = OnPreValueChange(value);
                PreValueChangeEvent?.Invoke(value);
                this.value = value;
                OnPostValueChange(this.value);
                PostValueChangeEvent?.Invoke(this.value);
            }
        }
        
        /// <summary>
        /// 値が変化する前に呼び出されるイベント
        /// </summary>
        public Action<float> PreValueChangeEvent;
        /// <summary>
        /// 値が変化した後に呼び出されるイベント
        /// </summary>
        public Action<float> PostValueChangeEvent;

        /// <summary>
        /// ステータス参照時にマイナスを返すのを許容するかどうかの真偽値
        /// </summary>
        [SerializeField] public bool AllowMinusVlaue = true;
        
        /// <summary>
        /// 値が変化する前に呼び出される仮想メソッド
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        protected virtual float OnPreValueChange (float value) { return value; }
        /// <summary>
        /// 値が変化した後に呼び出される仮想メソッド
        /// </summary>
        /// <param name="value"></param>
        protected virtual void OnPostValueChange (float value) { }
    }
}