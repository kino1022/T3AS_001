using System;
using System.Collections.Generic;
using UnityEngine;

namespace Test.Character.Ability {
    /// <summary>
    /// 習得済みのアビリティを管理するコンポーネント
    /// </summary>
    public class AbilityList : MonoBehaviour {
        /// <summary>
        /// 習得しているアビリティのリスト
        /// </summary>
        [SerializeField] public List<A_Ability> abilities;
        /// <summary>
        /// アビリティ習得の際に発火されるイベント
        /// </summary>
        public Action<A_Ability> wasLearn;
        /// <summary>
        /// アビリティを忘れた際に発火されるイベント
        /// </summary>
        public Action<A_Ability> wasRemoved;

        private void Start () {

        }

        private void Update () {

        }
        /// <summary>
        /// 新規アビリティ習得の際に呼ぶメソッド
        /// </summary>
        /// <param name="constructor"></param>
        /// <typeparam name="T"></typeparam>
        public void LearnNewAbility<T> (Func<T> constructor) where T : A_Ability {
            var newAbility = constructor();
            abilities.Add(newAbility);
            Debug.Log($"{newAbility.name}を習得しました！");
            wasLearn?.Invoke(newAbility);
        }
    }
}