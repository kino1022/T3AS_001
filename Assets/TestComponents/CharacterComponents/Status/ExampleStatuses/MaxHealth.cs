using System;
using GenerallySys.CollectionManageSys;
using UnityEngine;

namespace Test.Character.Status.Examples{
    public class MaxHealth : A_DevStatus {
        /// <summary>
        /// �񕜗ʂ̕␳�l���Ǘ�����N���X
        /// </summary>
        [SerializeField] public A_CollectionManager healValueCollection;

        protected override void WasStartColled(){
            base.WasStartColled();
            
        }
    }
}