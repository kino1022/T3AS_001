using UnityEngine;

namespace Test.Input {
    /// <summary>
    /// ボタンの各種情報を保管するクラス
    /// </summary>
    [System.Serializable]
    [CreateAssetMenu(fileName = "Input/ButtonData",menuName = "ButtonData")]
    public class ButtonData : ScriptableObject {
        /// <summary>
        /// ボタンの名前
        /// </summary>
        public string buttonName;
        /// <summary>
        /// PressからHoldに状態が移行するまでに要求する長押し時間
        /// </summary>
        public float phaseHoldTime = 0.2f;
    }
}