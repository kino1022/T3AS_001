using System;
using System.Collections.Generic;
using UnityEngine;
using Test.Definition;
using GenerallySys.CollectionManageSys;

namespace Test.Character.Resistance {
    /// <summary>
    /// 耐性値の管理を行うクラスの基底クラス
    /// </summary>
    public abstract class A_ResistanceManager : A_CollectionManager {
        /// <summary>
        /// 耐性を持つ対象の名前
        /// </summary>
        [SerializeField] private String _resistName;
        /// <summary>
        /// 耐性を持つ対象の属性
        /// </summary>
        [SerializeField] private Elements _elements;
    }
}