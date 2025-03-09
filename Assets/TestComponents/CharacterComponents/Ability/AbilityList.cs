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
        /// <summary>
        /// �A�r���e�B�K���̍ۂɔ��΂����C�x���g
        /// </summary>
        public Action<A_Ability> wasLearn;
        /// <summary>
        /// �A�r���e�B��Y�ꂽ�ۂɔ��΂����C�x���g
        /// </summary>
        public Action<A_Ability> wasRemoved;

        private void Start () {

        }

        private void Update () {

        }
        /// <summary>
        /// �V�K�A�r���e�B�K���̍ۂɌĂԃ��\�b�h
        /// </summary>
        /// <param name="constructor"></param>
        /// <typeparam name="T"></typeparam>
        public void LearnNewAbility<T> (Func<T> constructor) where T : A_Ability {
            var newAbility = constructor();
            abilities.Add(newAbility);
            Debug.Log($"{newAbility.name}���K�����܂����I");
            wasLearn?.Invoke(newAbility);
        }
    }
}