using UnityEngine;

namespace GenerallySys.Input.Button {
    /// <summary>
    /// ボタンの設定を管理するクラス
    /// </summary>
    [System.Serializable]
    [CreateAssetMenu(menuName = "GenerallySys/Input/Button/Data",fileName = "ButtonData",order = 0)]
    public class ButtonData : ScriptableObject {
        /// <summary>
        /// ボタンが押下から長押しに転じるまでに要求する押下時間
        /// </summary>
        public float phaseHold = 0.2f;
    }
}