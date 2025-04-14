using System;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

namespace GenerallySys.MoveControlSys.InertialSys {
    /// <summary>
    /// �����̊��N���X
    /// </summary>
    public abstract class A_Inertial {

        private Vector3 _totalMoveValue = Vector3.zero;
        /// <summary>
        /// ���̊����̎������̈ړ���
        /// </summary>
        public Vector3 totalMoveValue {
            get { return _totalMoveValue; }
            set { _totalMoveValue = value; }
        }

        private Vector3 _direction = Vector3.zero;
        /// <summary>
        /// �����̓��������̕W�����x�N�g��
        /// </summary>
        public Vector3 direction {
            get { return _direction; }
            set {
                _direction = value.normalized;
                totalMoveValue = movement * direction;
            }
        }

        private float _movement = 0.0f;
        /// <summary>
        /// �����̑傫��
        /// </summary>
        public float movement {
            get { return _movement; }
            set {
                movement = value;
                totalMoveValue = _movement * direction;
            }
        }

        /// <summary>
        /// �����ʊǗ��N���X���C���X�^���X����̈�
        /// </summary>
        private InertialMovement _inertialMovement;

        /// <summary>
        /// �������L�����ǂ���
        /// </summary>
        public Boolean enable = true;

        public A_Inertial (Vector3 setDirection,float setMovement,float setDumping) {
            direction = setDirection;
            _inertialMovement = new InertialMovement(this, setMovement, setDumping);
        }
    }
}