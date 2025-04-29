namespace Example.UtilityAI {
    /// <summary>
    /// 行動判断の条件になる要素を記述するデータ
    /// </summary>
    [System.Serializable]
    public abstract class AJudgeMaterial {
        
        /// <summary>
        /// 条件が満たされているか
        /// </summary>
        protected bool isCleared = false;
        
        /// <summary>
        /// 条件が満たされているかどうかを取得するメソッド
        /// </summary>
        /// <returns></returns>
        public virtual bool GetIsTermCleared() {
            return isCleared;
        }
    }
}