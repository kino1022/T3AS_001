using System.Collections.Generic;
using GenerallySys.Input.Button.Reference;
using UnityEngine;

namespace GenerallySys.Input.Button.Parallel.Capture {
    public class InputCapture : MonoBehaviour {
        [SerializeField] private List<Button.Parallel.Data.InputData> _data;
    }
}