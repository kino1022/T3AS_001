using System;
using System.Collections.Generic;

namespace Example.UtilityAI {
    /// <summary>
    /// 攻撃や防御などの大まかな行動を表すデータ
    /// </summary>
    [Serializable]
    public class BasePattern {
        /// <summary>
        /// そのパターンの実行に際する判断条件
        /// </summary>
        public List<JudgeData> judges;
        
        /// <summary>
        /// このベースパターンに属する派生パターン
        /// </summary>
        public List<Pattern> patterns;
        
    }
}