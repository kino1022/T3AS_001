using System;
using UnityEngine;

namespace Test.Character.Mortion {
    /// <summary>
    /// モーションのコンポーネント
    /// </summary>
    public abstract class A_Mortion {
        /// <summary>
        /// モーションのデータ
        /// </summary>
        [SerializeField] public A_MortionData data;
    }
}