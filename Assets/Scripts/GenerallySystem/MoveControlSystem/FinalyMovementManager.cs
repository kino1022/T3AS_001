using GenerallySys.Utility;
using System;
using System.Collections.Generic;
using UnityEngine;
using static GenerallySys.Utility.GenerallyUtility;

namespace GenerallySys.MoveControlSys {
    /// <summary>
    /// �A�^�b�`����Ă��邷�ׂĂ�A_MoveValueManager���擾���āA���̑��ړ��ʂ��Z�o����R���|�[�l���g
    /// </summary>
    public class FinalyMovementManager : MonoBehaviour {
        /// <summary>
        /// �A�^�b�`����Ă��邷�ׂĂ�A_MoveValueManager
        /// </summary>
        [SerializeField]
        private List<A_MoveValueManager> _allManager = new List<A_MoveValueManager>();
        /// <summary>
        /// �g�[�^���̈ړ���
        /// </summary>
        [SerializeField]
        public Vector3 totalMovement = Vector3.zero;

        void Start() {
            _allManager = GenerallyUtility.GetComponentsOfType<A_MoveValueManager>(this.gameObject);
        }

        void Update() {
            totalMovement = GetTotalMoveValue();
        }
        /// <summary>
        /// _allManager�Ɋi�[����Ă���S�Ă�TotalMoveValue�����v�����l��ԋp���郁�\�b�h
        /// </summary>
        /// <returns></returns>
        private Vector3 GetTotalMoveValue () {
            var totalValue = Vector3.zero;
            foreach (var value in _allManager) {
                totalValue += value.TotalMoveValue;
            }
            return totalValue;
        }
    }
}