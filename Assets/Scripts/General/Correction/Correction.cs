using System;
using General.Correction.Definition;

namespace General.Correction {
    [System.Serializable]
    public class Correction {
        /// <summary>
        /// 補正値の分類
        /// </summary>
        public CorrectionType type;
        /// <summary>
        /// 補正値の値
        /// </summary>
        public float value;
        
        /// <summary>
        /// 補正が消滅した際に発火されるイベント
        /// </summary>
        public Action<Correction> CorrectionRemoveEvent;

        public Correction(CorrectionType type, float value) {
            this.type = type;
            this.value = value;
            Initialize();
        }

        protected void Initialize() {
            OnInitialize();
        }
        
        protected virtual void OnInitialize() {}
    }
}