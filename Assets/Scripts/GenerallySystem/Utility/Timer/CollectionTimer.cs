using System;
using System.Threading;
using Cysharp.Threading.Tasks;

namespace GenerallySys.Utility.Timer 
{
    public class CollectionTimer : A_Timer
    {
        /// <summary>
        /// 補正値の残り時間を管理するタイマー
        /// </summary>
        /// <param name="duration"></param>
        /// <param name="token"></param>
        public CollectionTimer (float duration,CancellationToken token)
        {
            restTime = duration;
            taskToken = token;

            DecreaseRestTime(token,0.01f).Forget();
        }
    }
}