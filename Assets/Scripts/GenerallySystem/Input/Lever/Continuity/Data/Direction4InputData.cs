using System.Collections.Generic;
using GenerallySys.Definition;
using GenerallySys.Definition.Direction;
using GenerallySys.Input.Lever.Continuity.Capture;
using UnityEngine;

namespace GenerallySys.Input.Lever.Continuity.Data {
    [System.Serializable]
    [CreateAssetMenu(menuName = "GenerallySys/Input/Lever/Continuity/Direction4", fileName = "Direction4InputData")]
    public class Direction4InputData : A_InputData {
        public List<Direction4> directions;

        public override A_CaptureSystem CreateCaptureSystem() {
            return new Direction4CaptureSystem(reference.GetLever(), directions, intervals, callback);
        }
    }
}