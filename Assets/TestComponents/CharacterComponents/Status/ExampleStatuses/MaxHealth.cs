using System;
using GenerallySys.CollectionManageSys;
using UnityEngine;

namespace Test.Character.Status.Examples{
    public class MaxHealth : A_DevStatus {
        /// <summary>
        /// 回復量の補正値を管理するクラス
        /// </summary>
        [SerializeField] public A_CollectionManager healValueCollection;
        
    }
}