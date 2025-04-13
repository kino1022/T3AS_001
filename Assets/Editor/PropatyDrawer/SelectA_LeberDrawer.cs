using Attributes;
using Test.Input;
using UnityEditor;
using UnityEngine;

namespace Editor.PropertyDrawer {
    [CustomPropertyDrawer(typeof(SelectA_LeberAttributes), true)]
    public class SelectA_LeberDrawer : UnityEditor.PropertyDrawer {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
            EditorGUI.BeginProperty(position, label, property);

            GameObject go = null;
            A_Leber current = property.objectReferenceValue as A_Leber;

            if (current != null) {
                go = current.gameObject;
            }

            if (go == null) {
                EditorGUI.PropertyField(position, property, label);
                EditorGUI.EndProperty();
                return;
            }
            
            var all = go.GetComponents<A_Leber>();
            string[] options = new string[all.Length];
            int currentIndex = -1;

            for (int i = 0; i < all.Length; i++) {
                options[i] = all[i].GetType().Name;
                if (all[i] == current) {
                    currentIndex = i;
                }
            }
            
            int selected = EditorGUI.Popup(position, label.text, currentIndex, options);

            if (selected >= 0 && selected < all.Length) {
                property.objectReferenceValue = all[selected];
            }
            
            EditorGUI.EndProperty();
        }
    }
}