using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.Events;

namespace Test.Input {
	public class MultiLeberInputCapture : MonoBehaviour {
		[SerializeField] private MultiLeberInputData _data;
		[SerializeField] public UnityEvent couseEvent;

		void Start() {
			if (_data.isEightDirection) {

			}
		}
	}
}
