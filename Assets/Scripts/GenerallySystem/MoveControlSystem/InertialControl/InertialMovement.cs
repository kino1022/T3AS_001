using Cysharp.Threading.Tasks;
using System;
using System.Threading;
using UnityEngine;


namespace GenerallySys.MoveControlSys.InertialSys {
    /// <summary>
    /// �����̈�莞�Ԃ��ƂɌ�������^���ʂ�\�����邽�߂̃N���X�B�C���X�^���X�������ۂ�A_Inertial�̎Q�Ƃ�v���B
    /// </summary>
    public class InertialMovement {

        private float movement = 0.0f;
        /// <summary>
        /// �Z�o���ꂽ�ړ��ʁB��������x�ɕR�t����ꂽ�����N���X�ɑ΂��đ������������B
        /// </summary>
        public float Movement {
            get { return movement; }
            set { 
                movement = value;
                inertial.movement = movement;
            }
        }

        /// <summary>
        /// �R�Â��銵���N���X�B
        /// </summary>
        private A_Inertial inertial;
        /// <summary>
        /// �����̌����ʁi0.0�b���Ɍ����������Ȃ����̂�O��Ƃ��Đݒ肷�鎖�B�j
        /// </summary>
        private float dumpingValue = 0.0f;
        /// <summary>
        /// �����̌����������s���Ԋu�B
        /// </summary>
        private float interval = 0.01f;
        /// <summary>
        /// Movement�����̒l����������ꍇ�Ɋ����̌����������~����臒l�B
        /// </summary>
        private float destractionValue = 0.002f;

        private CancellationTokenSource cts = new CancellationTokenSource();

        public InertialMovement(A_Inertial setInertial,float setMovement,float setDumping) {
            inertial = setInertial;
            Movement = setMovement;
            dumpingValue = setDumping;

            CancellationToken token = cts.Token;
            DecreaseMovement(cts.Token).Forget();
        }

        private async UniTaskVoid DecreaseMovement (CancellationToken token) {
            try {
                Debug.Log("�����^���ʂ̌����������J�n���܂�");
                while (!token.IsCancellationRequested || movement < destractionValue) {
                    await UniTask.Delay(TimeSpan.FromSeconds(interval));
                    Movement *= dumpingValue;
                    if (Movement < destractionValue) {
                        Debug.Log("�����^���ʂ̒l��臒l������������߁A�������[�v���I�����܂�");
                        break;
                    }
                    else if (token.IsCancellationRequested) {
                        Debug.Log("�L�����Z�����X���[���ꂽ�ׁA�������[�v���I�����܂��B");
                    }
                }
                Debug.Log("�����̌������[�v���I�����܂����B");
            }
            catch (OperationCanceledException) {

            }
            finally {
                inertial.enable = false;
            }
        }
    }
}