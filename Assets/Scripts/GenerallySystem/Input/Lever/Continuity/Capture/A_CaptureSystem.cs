using System.Collections.Generic;
using UnityEngine.Events;

namespace GenerallySys.Input.Lever.Continuity.Capture {
    public class A_CaptureSystem {
        protected A_Lever Lever;
        protected List<float> Intervals;
        protected UnityEvent callback;

        public A_CaptureSystem(A_Lever lever, List<float> intervals, UnityEvent callback) {
            this.Lever = lever;
            this.Intervals = intervals;
            this.callback = callback;
        }
    }
}