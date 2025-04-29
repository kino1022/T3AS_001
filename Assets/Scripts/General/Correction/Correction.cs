using System;
using Attribute;
using General.Correction.Definition;
using UnityEngine;

namespace General.Correction {
    [System.Serializable]
    public class Correction {
        /// <summary>
        /// 補正値の分類
        /// </summary>
        [SerializeReference,SelectableSerializeReference]
        public CorrectionType Type;
        /// <summary>
        /// 補正値の値
        /// </summary>
        public float value;
        /// <summary>
        /// 補正が消滅した際に発火されるイベント
        /// </summary>
        public Action<Correction> CorrectionRemoveEvent;

        public Correction(CorrectionType type, float value) {
            this.Type = type;
            this.value = value;
            Initialize();
        }

        protected void Initialize() {
            OnInitialize();
        }
        
        protected virtual void OnInitialize() {}
    }
}