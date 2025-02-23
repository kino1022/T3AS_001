using System;
using System.Collections.Generic;
using UnityEngine;
using Test.Definition;
using GenerallySys.CollectionManageSys;

namespace Test.Character.Resistance {
    /// <summary>
    /// �ϐ��l�̊Ǘ����s���N���X�̊��N���X
    /// </summary>
    public abstract class A_ResistanceManager : A_CollectionManager {
        /// <summary>
        /// �ϐ������Ώۂ̖��O
        /// </summary>
        [SerializeField] private String _resistName;
        /// <summary>
        /// �ϐ������Ώ�
        /// </summary>
        public Elements _elements;
    }
}