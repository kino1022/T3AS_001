using System;
using UnityEngine;
using UnityEngine.Events;

namespace Test.Character.Skill {
    /// <summary>
    /// 全てのスキルの基底クラス
    /// </summary>
    public abstract class A_Skill {
        /// <summary>
        /// スキルの名前（ゲーム中の表記に用いる名前）
        /// </summary>
        [SerializeField] public string skillName;
        /// <summary>
        /// このスキルのデータ
        /// </summary>
        [SerializeField] private SkillData _data;

        [SerializeField] private int _level;

        /// <summary>
        /// 現在のスキルレベル
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
        /// スキルレベルが上がった際に呼び出されるイベント
        /// </summary>
        public UnityEvent<int> skillLevelUp;

        private void wasSkillLevelUp (int level) {
            foreach(var ability in _data.abilitys){
                if (ability.skillLevel == level) {
                    //アビリティリストのコンポーネントにアビリティを入れる処理ヲ書き込む。
                    return;
                }
            }
        }
    }
}