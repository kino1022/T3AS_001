using System;
using System.Collections.Generic;
using UnityEngine;

namespace General.MoveManager.Inertial {
    public class InertialManager : MovementManager {
        /// <summary>
        /// 管理している慣性のリスト
        /// </summary>
        private List<Inertial> inertials;
        
        private void Update() {
            this.Movement = CalcurateTotalMovement();
        }


        public void CreateNewInertials<T>(params object[] args) where T : Inertial {
            var inertial = (T)Activator.CreateInstance(typeof(T), args);
            inertials.Add(inertial);
            inertial.RemoveInertialEvent += OnRemoveInertial;
        }

        private Vector3 CalcurateTotalMovement() {
            var movement = Vector3.zero;
            foreach (var inertial in inertials) {
                movement += inertial.totalForce;
            }
            return movement;
        }

        private void OnRemoveInertial(Inertial inertial) {
            inertials.Remove(inertial);
        }
    }
}