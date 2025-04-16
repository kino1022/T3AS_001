using System.Collections.Generic;
using GenerallySys.Definition.Direction;
using GenerallySys.Input.Lever.Continuity.Capture;
using UnityEngine;

namespace GenerallySys.Input.Lever.Continuity.Data {
    [System.Serializable]
    [CreateAssetMenu(menuName = "GenerallySys/Input/Lever/Continuity/Direction8",fileName = "Direction8InputData")]
    public class Direction8InputData : A_InputData {
        public List<Direction8> directions;


        public override A_CaptureSystem CreateCaptureSystem() {
            return new Direction8CaptureSystem(
                reference.GetLever(), 
                intervals, 
                callback, 
                directions);
        }
    }
}