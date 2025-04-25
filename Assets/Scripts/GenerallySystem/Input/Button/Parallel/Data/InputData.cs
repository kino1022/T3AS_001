using System.Collections.Generic;
using System.Linq;
using GenerallySys.Definition;
using GenerallySys.Input.Button.Reference;
using UnityEngine;
using UnityEngine.Events;

namespace GenerallySys.Input.Button.Parallel.Data {
    /// <summary>
    /// ボタン同時入力のデータ
    /// </summary>
    [System.Serializable]
    [CreateAssetMenu(menuName = "GenerallySys/Input/Button/Parallel/Data",fileName = "ParallelInputData")]
    public class InputData : ScriptableObject {
        /// <summary>
        /// 同時押しに要求するボタンの参照
        /// </summary>
        public List<ButtonReference> references;
        /// <summary>
        /// いずれかのボタンが押下された時から全てのボタンが入力されるまでに許容する猶予
        /// </summary>
        public float grace;
        /// <summary>
        /// 入力成立時に発火されるイベント
        /// </summary>
        public UnityEvent callback;

        /// <summary>
        /// 参照を元にボタンのリストを返すメソッド
        /// </summary>
        /// <returns></returns>
        public List<A_Button> GetButtonsFromReference() {
            return references
                .Select(r => r.GetButton())
                .Where(b => b != null)
                .ToList();
        }
    }
}