using System;
using System.Collections.Generic;
using System.Threading;
using Cysharp.Threading.Tasks;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

namespace Test.Input {
    /// <summary>
    /// �w�肵���Ԋu�E���Ԃ̃{�^�����͂����m���ăC�x���g�𔭉΂���
    /// </summary>
    public class MultiButtonInputCapture : MonoBehaviour {
        /// <summary>
        /// �v�����̓f�[�^
        /// </summary>
        [SerializeField] private MultiButtonInputData _data;
        /// <summary>
        /// ���͐������ɔ��΂����C�x���g
        /// </summary>
        public UnityEvent couseEvent;

        private void Start () {
            _data.buttonsPattern[1].wasPress.AddListener(StartInputCapture);
        }

        private void StartInputCapture () {
            Debug.Log($"{this.name}�̘A�����͌��m�^�X�N���N�����܂�");
            InputCapture(this.GetCancellationTokenOnDestroy(),_data.buttonsPattern,_data.interval).Forget();
        }

        async private UniTaskVoid InputCapture (CancellationToken token,List<A_Button> pattern,List<float> interval) {
            try{
                var succese = true;
                Debug.Log($"{this.name}�̘A�����͌��m�^�X�N���J�n���܂�");
                for (int i = 0; i < pattern.Count; i++) {
                    var wasInput = await WaitForUnityEvent(pattern[i].wasPress,interval[i]);

                    if (wasInput) {
                        Debug.Log($"{i + 2}��ڂ̓��͔���ɐ������܂���{i + 3}��ڂ̓��͔���Ɉڍs���܂��B");
                    }
                    else {
                        succese = false;
                        break;
                    }
                }

                if (succese) {
                    Debug.Log($"{this.name}�̘A�����͔���ɐ������܂���");
                    couseEvent?.Invoke();
                }
                else {
                    Debug.Log($"{this.name}�̘A�����͔���Ɏ��s���܂���");
                }
            }
            catch (OperationCanceledException) {

            }
            finally {

            }
        }

        public async UniTask<Boolean> WaitForUnityEvent (UnityEvent unityEvent,float timeout) {
            try {
                var tcs = new UniTaskCompletionSource();

                unityEvent.AddListener(OnTrigger);

                var completedTask = await UniTask.WhenAny(tcs.Task,UniTask.Delay(TimeSpan.FromSeconds(timeout)));

                if (completedTask == 0) {
                    return true;
                }
                else {
                    return false;
                }

                void OnTrigger () {
                    tcs.TrySetResult();
                    unityEvent.RemoveListener(OnTrigger);
                }
            }
            catch (OperationCanceledException) {
                return false;
            }
            finally {

            }
        }
    }
}