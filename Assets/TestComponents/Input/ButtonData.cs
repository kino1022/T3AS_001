using UnityEngine;

namespace Test.Input {
    [System.Serializable]
    [CreateAssetMenu(fileName = "ButtonData",menuName = "ButtonData")]
    /// <summary>
    /// ボタンの各種情報を格納する
    /// </summary>
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