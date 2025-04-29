using System.Collections.Generic;
using UnityEngine;

namespace CharacterAction {
    /// <summary>
    /// 使用できるActionを管理するマネージャクラス
    /// </summary>
    public class CharacterActionManager : MonoBehaviour {
        /// <summary>
        /// 使用できるアクションのリスト
        /// </summary>
        [SerializeField] public List<CharacterAction> activeActions;
    }
}