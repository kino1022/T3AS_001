using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GenerallySys.MoveControlSys.InertialSys {
    /// <summary>
    /// ���ݓ����Ă��銵�����Ǘ�����N���X
    /// </summary>
    public class InertialManager : MonoBehaviour {
        /// <summary>
        /// ���ݓ����Ă��銵���̃��X�g
        /// </summary>
        public List<A_Inertial> inertials = new List<A_Inertial>();

        private void Start() {

        }

        private void Update() {
            ReleaseNotEnableInertial();
        }

        /// <summary>
        /// �L��������Ă��Ȃ����������X�g���珜�O���郁�\�b�h
        /// </summary>
        private void ReleaseNotEnableInertial () {
            for (int i = 0; i < inertials.Count; i++) {
                if (!inertials[i].enable) {
                    inertials.RemoveAt(i);
                }
            }
        }
    }
}