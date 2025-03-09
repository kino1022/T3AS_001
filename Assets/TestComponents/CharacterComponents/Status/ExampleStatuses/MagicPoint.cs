using System;
using GenerallySys.CollectionManageSys;
using UnityEngine;

namespace Test.Character.Status {
    /// <summary>
    /// 現在のMPを管理するコンポーネント
    /// </summary>
    public class MagicPoint : MonoBehaviour {
        /// <summary>
        /// MPの消費量にかかる補正値を管理するコンポーネント
        /// </summary>
        [SerializeField] public A_CollectionManager consumeValueManager;
    }
}