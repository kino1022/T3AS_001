using System;
using System.Collections.Generic;
using UnityEngine;

namespace Test.Character.Skill {
    /// <summary>
    /// �Z�b�g���̃X�L�����Ǘ�����R���|�[�l���g
    /// </summary>
    public class SkillList : MonoBehaviour {

        private int _slotAmount;
        /// <summary>
        /// �X�L���X���b�g�̍ő吔
        /// </summary>
        /// <value></value>
        public int slotAmount {
            get{return _slotAmount;}
            set{
                if (0 <= value) {
                    _slotAmount = value;
                }
            }
        }
        /// <summary>
        /// ���݃Z�b�g���̃X�L��
        /// </summary>
        [SerializeField] public List<A_Skill> skills;

        public void AddNewSkill (A_Skill newSkill) {

        }
    }
}