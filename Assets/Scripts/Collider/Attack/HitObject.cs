using Common.Utility;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace Collider.Attack {
    public class HitObject {
        /// <summary>
        /// 衝突したオブジェクト
        /// </summary>
        public GameObject hitObject;
        
        ///フレームカウンタ
        public FrameCounter FrameCounter;

        public HitObject() {
            FrameCounter = new FrameCounter();
        }
    }
}