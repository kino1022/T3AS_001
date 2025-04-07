using System;
using GenerallySys.CollectionManageSys;
using UnityEngine;

namespace Test.Character.Status.Examples{
    /// <summary>
    /// 体力の最大値を管理するコンポーネント(テストコンポーネント)
    /// </summary>
    public class MaxHealth : A_DevStatus {
        protected override void WasStartColled(){
            base.WasStartColled();
            
        }
    }
}