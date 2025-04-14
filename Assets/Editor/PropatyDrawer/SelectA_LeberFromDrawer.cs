using System.Reflection;
using Attributes;
using Test.Input;
using UnityEditor;
using UnityEngine;

namespace Editor.PropertyDrawer {
    [CustomPropertyDrawer(typeof(SelectA_LeberFromAttribute))]
    public class SelectA_LeberFromDrawer : UnityEditor.PropertyDrawer {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
            EditorGUI.BeginProperty(position, label, property);
            
            var attr = attribute as SelectA_LeberFromAttribute;
            var targetObject = property.serializedObject.targetObject;
            var containerType = targetObject.GetType();

            FieldInfo fieldInfo = containerType.GetField(
                attr.targetGameObjectField,
                BindingFlags.NonPublic
                | BindingFlags.Public
                | BindingFlags.Instance
                );
            
            if (fieldInfo == null) {
                EditorGUI.LabelField(position,label.text,$"GameObjectフィールド{attr.targetGameObjectField}が見つかりません");
                EditorGUI.EndProperty();
                return;
            }
            
            GameObject go = fieldInfo.GetValue(targetObject) as GameObject;

            if (go == null) {
                EditorGUI.LabelField(position,label.text,$"GameObjectが未指定です");
                EditorGUI.EndProperty();
                return;
            }
            
            var components = go.GetComponents<Component>();
            string[] options = new string[components.Length];
            int selectedIndex = -1;

            for (int i = 0; i < components.Length; i++) {
                options[i] = components[i].GetType().Name;
                if (components[i] == property.objectReferenceValue) {
                    selectedIndex = i;
                }
            }
            
            int newIndex = EditorGUI.Popup(position, label.text, selectedIndex, options);
            
            if (newIndex >= 0 && newIndex < components.Length) {
                property.objectReferenceValue = components[newIndex];
            }
            
            EditorGUI.EndProperty();
        }
    }
}