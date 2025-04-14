using System;
using System.Collections.Generic;
using System.Linq;
using Cysharp.Threading.Tasks;
using Reference;
using UnityEngine;
using Reference;
using UnityEngine.Events;

namespace Test.Input.Ver2Test {
    [Serializable]
    [CreateAssetMenu(menuName = "Input/Multi2/Button", fileName = "MultiButtonInputData")]
    public class MultiButtonInputData2 : ScriptableObject {
        public List<ButtonReference> references;
        public List<float> intervals;
        public UnityEvent couseEvent;

        public List<A_Button> GetButtonsFromReferences() {
            return references
                .Select(r => r.GetButton())
                .Where(b => b != null)
                .ToList();
        }
    }
}