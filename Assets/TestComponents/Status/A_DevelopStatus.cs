using System;
using UnityEngine;
using Test.Status;

namespace Test.Status {
    /// <summary>
    /// A_statusを継承したコンポーネントのstatusの変化に伴って変化する発展ステータスの基底クラス
    /// </summary>
    public abstract class A_DevelopStatus : A_Status {

        /// <summary>
        /// もとになるステータス
        /// </summary>
        [SerializeField] private A_Status baseStatus;

        

        protected virtual void GetBaseValueChange (float baseValue) {

        }
    }
}