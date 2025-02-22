using System;
using UnityEngine;

namespace Test.Character.Resistance {
    /// <summary>
    /// 耐性値の管理を行うクラスの基底クラス
    /// </summary>
    public abstract class A_ResistanceManager : MonoBehaviour {
        /// <summary>
        /// 耐性値の名前
        /// </summary>
        [SerializeField] private string _resisteName;
    }
}