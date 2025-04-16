using System;
using System.Collections.Generic;
using GenerallySys.Input.Lever.Continuity.Data;
using UnityEngine;

namespace GenerallySys.Input.Lever.Continuity.Capture {
    /// <summary>
    /// レバーの特定方向への連続入力を検知するコンポーネント
    /// </summary>
    public class InputCapture : MonoBehaviour {
        
        /// <summary>
        /// 入力判定を行う判定のデータ
        /// </summary>
        [SerializeField] private List<A_InputData> _datas;
        
        /// <summary>
        /// インスタンス化された入力判定クラス
        /// </summary>
        private List<A_CaptureSystem> _captures = new List<A_CaptureSystem>();

        private void Start() {
            foreach (A_InputData data in _datas) {
                _captures.Add(data.CreateCaptureSystem());
            }
        }
    }
}