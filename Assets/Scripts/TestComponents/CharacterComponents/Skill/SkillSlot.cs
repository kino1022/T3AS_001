using System;
using System.Collections.Generic;
using UnityEngine;

namespace Test.Character.Skill {
    /// <summary>
    /// セット中のスキルを管理するコンポーネント
    /// </summary>
    public class SkillList : MonoBehaviour {

        private int _slotAmount;
        /// <summary>
        /// スキルスロットの最大数
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
        /// 現在セット中のスキル
        /// </summary>
        [SerializeField] public List<A_Skill> skills;

        public void AddNewSkill (A_Skill newSkill) {

        }
    }
}