using System;
using GenerallySys.CollectionManageSys;
using UnityEngine;

namespace Test.Character.Status {
    /// <summary>
    /// ���݂�MP���Ǘ�����R���|�[�l���g
    /// </summary>
    public class MagicPoint : MonoBehaviour {
        /// <summary>
        /// MP�̏���ʂɂ�����␳�l���Ǘ�����R���|�[�l���g
        /// </summary>
        [SerializeField] public A_CollectionManager consumeValueManager;
    }
}