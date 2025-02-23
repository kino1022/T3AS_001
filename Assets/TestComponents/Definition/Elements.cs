using System;
using UnityEngine;

namespace Test.Definition {
    /// <summary>
    /// �����񕨗��S�Ă̑�������
    /// </summary>
    public enum Elements {
        /// <summary>
        /// �a������
        /// </summary>
        Slash,
        /// <summary>
        /// �Ō�����
        /// </summary>
        Blow,
        /// <summary>
        /// �h�ˑ���
        /// </summary>
        Pierting,
        /// <summary>
        /// �ˌ�����
        /// </summary>
        Shot,
        Fire,
    }
    /// <summary>
    /// �����_���[�W�̑�������
    /// </summary>
    public enum PhysicalElement {
        /// <summary>
        /// �a������
        /// </summary>
        Slash = Elements.Slash,
        /// <summary>
        /// �Ō�����
        /// </summary>
        Blow = Elements.Blow,
        /// <summary>
        /// �h�ˑ���
        /// </summary>
        Pierting = Elements.Pierting,
        /// <summary>
        /// �ˌ�����
        /// </summary>
        Shot = Elements.Shot,
    }
}