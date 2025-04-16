using System.Linq;
using GenerallySys.Input.Lever;
using UnityEngine;

namespace GenerallySys.Input.Button.Reference {
    [System.Serializable]
    public class ButtonReference {
        public GameObject target;
        public string typeName;

        public A_Button GetButton() {
            return target.GetComponents<A_Button>()
                .FirstOrDefault(b => b.GetType().Name == typeName);
        }
    }
}