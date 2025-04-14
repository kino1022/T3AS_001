using System;
using System.Linq;
using Test.Input;
using Unity.VisualScripting;
using UnityEngine;

namespace Reference {
    [System.Serializable]
    public class ButtonReference {
        /// <summary>
        /// 指定したボタンを持つゲームオブジェクト
        /// </summary>
        public GameObject target;
        /// <summary>
        /// 指定したボタンの指定名
        /// </summary>
        public String typeName;
        
        /// <summary>
        /// 指定されたボタンを返すメソッド
        /// </summary>
        /// <returns></returns>
        public A_Button GetButton() {
            if (target == null || string.IsNullOrEmpty(typeName)) return null;
            return target.GetComponents<A_Button>().FirstOrDefault(b => b.GetType().Name == typeName);
        }
    }
}
