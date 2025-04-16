using System.Collections.Generic;
using GenerallySys.Input.Lever.Continuity.Capture;
using GenerallySys.Input.Lever.Reference;
using UnityEngine;
using UnityEngine.Events;

namespace GenerallySys.Input.Lever.Continuity.Data {
    public abstract class A_InputData : ScriptableObject{
        public LeverReference reference;
        public List<float> intervals;
        public UnityEvent callback;

        public virtual A_CaptureSystem CreateCaptureSystem() {
            return null;
        }
    }
}