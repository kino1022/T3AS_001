using System;
using System.Threading;
using Cysharp.Threading.Tasks;
using GenerallySys.Definition;
using Test.Definition;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;
using static GenerallySys.Definition.ButtonCondition;
using static GenerallySys.Utility.GenerallyUtility;

namespace Test.Input {
    /// <summary>
    /// �S�Ẳ��z�{�^���i�����I�ɑ��݂��鉟����Ԃ��Ǘ�����N���X�j�̊��N���X
    /// </summary>
    public abstract class A_Button : MonoBehaviour {
        /// <summary>
        /// �K�p����{�^���̃f�[�^
        /// </summary>
        private ButtonData _data;
        /// <summary>
        /// �������Ɉڍs����܂łɗv�����鉟������
        /// </summary>
        private float _phaseHold;
        /// <summary>
        /// �{�^����Ԃ�Hold�ɂȂ��Ă��牟�����ꑱ��������
        /// </summary>
        private float _HoldTime = 0.0f;

        private ButtonCondition _condition = None;
        /// <summary>
        /// ���݂̃{�^���̏��(�v���p�e�B)
        /// </summary>
        /// <value></value>
        public ButtonCondition condition {
            get{return _condition;}
            set {
                //��Ԃ�Hold����Press�ɑJ�ڂ����ۂ̔��Ώ���
                if (_condition == Hold || value == None){
                    wasRelease?.Invoke(_HoldTime);
                }
                //��Ԃ�None����Press�ɑJ�ڂ����ۂ̔��Ώ���
                else if (_condition == None || value == Press) {
                    wasPress?.Invoke();
                }
                _condition = value;
            }
        }

        /// <summary>
        /// �{�^����None����Press�ɕω������ۂɔ��΂����UnityEvent�B
        /// </summary>
        public UnityEvent wasPress;

        /// <summary>
        /// �{�^����Hold����None�ɕω������ۂɔ��΂����UnityEvent�A������_HoldTime
        /// </summary>
        public UnityEvent<float> wasRelease;

        private void Start () {
            if (_data != null) {
                _phaseHold = _data.phaseHoldTime;
            }
            else {
                Debug.Log($"{this.name}��ButtonData���A�^�b�`����Ă��܂���!!");
            }
        }

        /// <summary>
        /// InputSystem����Ăяo����郁�\�b�h
        /// </summary>
        /// <param name="context"></param>
        public void WasPress (InputAction.CallbackContext context) {
            if (context.performed) {
                Debug.Log($"{this.name}�Ɋ��蓖�Ă�ꂽ�{�^������������܂���");
                if (_condition == None) {
                    _condition = Press;
                    PhaseHoldTimer(this.GetCancellationTokenOnDestroy(),_phaseHold).Forget();
                }
            }
            if (context.canceled) {
                Debug.Log($"{this.name}�Ɋ��蓖�Ă�ꂽ�{�^����������܂���");
                if (condition != None) {
                    condition = None;
                }
                else{
                    Debug.Log($"{this.name}�œ�d�̃����[�X�������������܂����B");
                }
            }
        }

        /// <summary>
        /// �{�^�����w�莞�ԉ����ꑱ�����ꍇ��Press����Hold�ɏ�Ԉڍs���s���^�X�N(������)
        /// </summary>
        /// <param name="token"></param>
        /// <param name="waitTime"></param>
        /// <returns></returns>
        async private UniTaskVoid PhaseHoldTimer (CancellationToken token, float waitTime) {
            try {
                if (this.condition == Press) {
                    condition = Hold;
                }
            }
            catch(OperationCanceledException) {

            }
            finally {

            }
        }
    }
}