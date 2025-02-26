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

        private void Start () {

        }

        private void Update () {

        }

        public void LearnNewAbility<T> (Func<T> constructor) where T : A_Ability {
            var newAbility = constructor();
            abilities.Add(newAbility);
            Debug.Log($"{newAbility.name}を習得しました！");
        }
    }
}