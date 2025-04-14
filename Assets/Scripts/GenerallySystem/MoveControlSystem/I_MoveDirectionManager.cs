using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GenerallySys.MoveControlSys {
    /// <summary>
    /// �L�����N�^�[�̈ړ��������Ǘ�����N���X�ɑ΂��Ď�������C���^�[�t�F�[�X
    /// </summary>
    public interface I_MoveDirectionManager {
        /// <summary>
        /// �L�����N�^�[�̈ړ�����
        /// </summary>
        public Vector3 MoveDirection { get; set; }
        /// <summary>
        /// �ړ������̃x�N�g����n���}�l�[�W���[�N���X
        /// </summary>
        public A_MoveValueManager Manager { get; set; }
    }
}