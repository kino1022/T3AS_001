using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GenerallySys.MoveControlSys {
    /// <summary>
    /// �L�����N�^�[�̈ړ��ʂ̑傫�����Ǘ�����R���|�[�l���g�ɑ΂��Ď�������C���^�[�t�F�[�X
    /// </summary>
    public interface I_MovementManager {
        /// <summary>
        /// �L�����N�^�[�̈ړ��ʂ̑傫��
        /// </summary>
        public float Movement { get; set; }
        /// <summary>
        /// �ړ��ʂ̑傫����n���Ώۂ�A_MoveValueManager
        /// </summary>
        public A_MoveValueManager Manager { get; set; }
    }
}