using System;
using System.Collections.Generic;
using UnityEngine;

namespace Test.Character.Ability {
    /// <summary>
    /// �K���ς݂̃A�r���e�B���Ǘ�����R���|�[�l���g
    /// </summary>
    public class AbilityList : MonoBehaviour {
        /// <summary>
        /// �K�����Ă���A�r���e�B�̃��X�g
        /// </summary>
        [SerializeField] public List<A_Ability> abilities;

        private void Start () {

        }

        private void Update () {

        }

        public void LearnNewAbility<T> (Func<T> constructor) where T : A_Ability {
            var newAbility = constructor();
            abilities.Add(newAbility);
            Debug.Log($"{newAbility.name}���K�����܂����I");
        }
    }
}