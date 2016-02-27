using UnityEngine;
using UnityEditor;

namespace MonoBehaviorInh.Editor
{
    [CustomEditor(typeof(Test2))]
    [CanEditMultipleObjects]
    public class Test2Editor : UnityEditor.Editor
    {
        private SerializedProperty _enum;
        private SerializedProperty _int;


        private void OnEnable()
        {
            _enum = serializedObject.FindProperty("_testEnum1");
            _int = serializedObject.FindProperty("_testInt");
        }

        public override void OnInspectorGUI()
        {
            serializedObject.Update();
            EditorGUILayout.PropertyField(_enum);
            if (_enum.enumValueIndex == 3)
            {
                EditorGUILayout.IntSlider(_int, 0, 100);
            }
            serializedObject.ApplyModifiedProperties();
        }
    }

}
