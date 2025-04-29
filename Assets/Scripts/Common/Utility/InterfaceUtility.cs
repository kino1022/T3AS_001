using System.Collections.Generic;
using System.Reflection;
using Unity.VisualScripting;
using UnityEngine;

namespace Common.Utility {
    public static class InterfaceUtility {
        /// <summary>
        /// 指定したインターフェースを持つフィールドを取得する
        /// </summary>
        /// <param name="target"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static List<T> GetAnyInterfaces<T>(this System.Object target) {
            List<T> interfaces = new List<T>();
            var fields = target
                .GetType()
                .GetFields(
                BindingFlags.Instance |
                BindingFlags.Public |
                BindingFlags.NonPublic
                );
            foreach (var field in fields) {
                var value = field.GetValue(target);
                if (value is T t) {
                    interfaces.Add(t);
                }
            }
            return interfaces;
        }
    }
}