using UnityEngine;

namespace General.Status {
    /// <summary>
    /// MaxStatusとセットで最大値と現在値を管理するコンポーネント
    /// </summary>
    public class CurrentStatus : Status {
        
        //現在地が最大値を超えないようにする仕組みを用意すること
        
        /// <summary>
        /// ステータスの最大値
        /// </summary>
        [SerializeField] private MaxStatus maxStatus;
        
        /// <summary>
        /// 最大値に対する現在値の割合
        /// </summary>
        [SerializeField] public float valueRatio;

        protected override void OnStart() {
            this.value.PostValueChangeEvent += OnValueChange;
            maxStatus.value.PostValueChangeEvent += OnValueChangeInMaxStatus;
        }

        /// <summary>
        /// このクラスのステータス値が変化した際に発火されるメソッド
        /// </summary>
        /// <param name="value"></param>
        private void OnValueChange(float value) {
            valueRatio = CalcurateValueRatio();
        }
        
        /// <summary>
        /// 最大値の管理クラスにおいて最大の値が変化した際に発火されるメソッド
        /// </summary>
        /// <param name="value"></param>
        private void OnValueChangeInMaxStatus(float value) {
            valueRatio = CalcurateValueRatio();
        }
        
        
        private float CalcurateValueRatio () {
            return maxStatus.value.Value / this.value.Value;
        }
    }
}