using System;
using UnityEngine;
using Test.Status;

namespace Test.Status {
    /// <summary>
    /// A_status���p�������R���|�[�l���g��status�̕ω��ɔ����ĕω����锭�W�X�e�[�^�X�̊��N���X
    /// </summary>
    public abstract class A_DevelopStatus : A_Status {

        /// <summary>
        /// ���ƂɂȂ�X�e�[�^�X
        /// </summary>
        [SerializeField] private A_Status baseStatus;

        private void Start() {
            baseStatus.wasValueChanged += GetBaseValueChange;
        }

        protected virtual void GetBaseValueChange (float baseValue) {

        }
    }
}