using System.Collections.Generic;
using NUnit.Framework;
using Reference;
using UnityEngine;
using UnityEngine.Events;

namespace Test.Input.Ver2Test {
    public class MultiButtonInputCapture2 : MonoBehaviour {
        [SerializeField] private List<MultiButtonInputData> _data;
        private List<CaptureSystem> _captures = new List<CaptureSystem>();

        void Start() {
            
        }

        private void CreateNewCaptureSystem(MultiButtonInputCapture2 data) {
            var buttons = new List<A_Button>();
        }

        partial class CaptureSystem {
            private List<A_Button> _buttons = new List<A_Button>();
            private List<float> _intervals = new List<float>();
            private UnityEvent _couseEvent;

            public CaptureSystem(List<A_Button> buttons, List<float> intervals, UnityEvent couseEvent) {
                this._buttons = buttons;
                this._intervals = intervals;
                this._couseEvent = couseEvent;
            }
        }
    }
}