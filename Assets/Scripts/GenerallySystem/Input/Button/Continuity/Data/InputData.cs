using System.Collections.Generic;
using System.Linq;
using GenerallySys.Definition;
using GenerallySys.Input.Button.Reference;
using UnityEngine;
using UnityEngine.Events;

namespace GenerallySys.Input.Button.Continuity.Data {
    [System.Serializable]
    [CreateAssetMenu(menuName = "GenerallySys/Input/Button/Continuity/Data",fileName = "ContinuityInputData",order = 0)]
    public class InputData {
        public List<ButtonReference> references;
        public List<float> intervals;
        public UnityEvent callback;

        public List<A_Button> GetButtonsFromReference() {
            return references
                .Select(r =>  r.GetButton())
                .Where(b => b != null)
                .ToList();
        }
    }
}