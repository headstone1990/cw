using UnityEngine;
using UnityEditor;

namespace MonoBehaviorInh.CatEditor.Editor
{
    [CustomEditor(typeof(EditorAssigner))]
    [CanEditMultipleObjects]
    public class EditorAssignerEditor : UnityEditor.Editor
    {
        private SerializedProperty _catPainter;
        private SerializedProperty _part;
        private SerializedProperty _faceType;
        private SerializedProperty _furryType;
        private SerializedProperty _eyesType;
        private SerializedProperty _eyesColor;
        private SerializedProperty _earsAndNose;
        private SerializedProperty _furColorAndStripsAndSpots;


        private void OnEnable()
        {
            _catPainter = serializedObject.FindProperty("_catPainter");
            _part = serializedObject.FindProperty("_part");
            _faceType = serializedObject.FindProperty("_faceType");
            _furryType = serializedObject.FindProperty("_furryType");
            _eyesType = serializedObject.FindProperty("_eyesType");
            _eyesColor = serializedObject.FindProperty("_eyesColor");
            _earsAndNose = serializedObject.FindProperty("_earsAndNose");
            _furColorAndStripsAndSpots = serializedObject.FindProperty("_furColorAndStripsAndSpots");
        }

        public override void OnInspectorGUI()
        {
            serializedObject.Update();
            EditorGUILayout.PropertyField(_catPainter);
            EditorGUILayout.PropertyField(_part, new GUIContent("Part"));
            switch (_part.enumValueIndex)
            {
                case 3:
                    EditorGUILayout.PropertyField(_faceType, new GUIContent("Value"));
                    break;
                case 2:
                    EditorGUILayout.PropertyField(_furryType, new GUIContent("Value"));
                    break;
                case 4:
                    EditorGUILayout.PropertyField(_eyesType, new GUIContent("Value"));
                    break;
                case 5:
                    EditorGUILayout.PropertyField(_eyesColor, new GUIContent("Value"));
                    break;
                case 6:
                case 7:
                    EditorGUILayout.PropertyField(_earsAndNose, new GUIContent("Value"));
                    break;
                default:
                    if (_part.enumValueIndex > 7)
                    {
                        EditorGUILayout.PropertyField(_furColorAndStripsAndSpots, new GUIContent("Value"));
                    }
                    break;
            }
            serializedObject.ApplyModifiedProperties();
        }
    }
}
