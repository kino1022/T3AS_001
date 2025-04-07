using System;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using GenerallySys.Definition;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using static GenerallySys.Definition.ButtonCondition;

namespace Test.Input {
    public class PararellButtonInputCapture : MonoBehaviour {
        /// <summary>
        /// 同時入力の判定を行う対象のデータ
        /// </summary>
        [SerializeField] private List<ParallelButtonInputData> _datas;
        /// <summary>
        /// インスタンスされた判定システム
        /// </summary>
        private List<CaptureSystem> _captures;

        void Start() {
            foreach (var data in _datas) {
                _captures.Add(new CaptureSystem(data));
            }
        }

        partial class CaptureSystem {
            public ParallelButtonInputData data;

            private List<A_Button> _buttons;

            public CaptureSystem (ParallelButtonInputData data) {
                this.data = data;
                foreach (var button in data.buttons) {
                    _buttons.Add(button);
                    button.wasPress.AddListener(ButtonWasPressed);
                }
            }

            private void ButtonWasPressed () {
                
            }
            
            private async UniTask ParallelInputCapture () {
                Boolean [] isPressed = new Boolean[_buttons.Count];
                for (int i = 0; i < _buttons.Count; i++ ) {

                    if (_buttons[i].condition != None) isPressed[i] = true;
                    else isPressed[i] = false;

                    int index = i;

                    UnityAction action = null;

                    action = () => {
                        isPressed[index] = true;
                        _buttons[index].wasPress.RemoveListener(action);
                    };

                    _buttons[i].wasPress.AddListener(action);
                }

                
            }
        }
    }
}