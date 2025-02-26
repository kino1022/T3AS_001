using System;
using UnityEngine;
using UnityEngine.Events;

namespace Test.Character.Skill {
    /// <summary>
    /// �S�ẴX�L���̊��N���X
    /// </summary>
    public abstract class A_Skill {
        /// <summary>
        /// �X�L���̖��O�i�Q�[�����̕\�L�ɗp���閼�O�j
        /// </summary>
        [SerializeField] public string skillName;
        /// <summary>
        /// ���̃X�L���̃f�[�^
        /// </summary>
        [SerializeField] private SkillData _data;

        [SerializeField] private int _level;

        /// <summary>
        /// ���݂̃X�L�����x��
        /// </summary>
        public int level {
            get{ 
                return _level;
            }
            set{
                _level = value;
                skillLevelUp?.Invoke(_level);
            }
        }
        /// <summary>
        /// �X�L�����x�����オ�����ۂɌĂяo�����C�x���g
        /// </summary>
        public UnityEvent<int> skillLevelUp;

        private void wasSkillLevelUp (int level) {
            foreach(var ability in _data.abilitys){
                if (ability.skillLevel == level) {
                    //�A�r���e�B���X�g�̃R���|�[�l���g�ɃA�r���e�B�����鏈�����������ށB
                    return;
                }
            }
        }
    }
}