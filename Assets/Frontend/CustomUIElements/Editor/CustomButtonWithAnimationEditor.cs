namespace CW.Frontend.CustomUIElements.Editor
{
    using CustomUIElements;
    using UnityEditor;
    using UnityEditor.UI;

    [CanEditMultipleObjects]
    [CustomEditor(typeof(CustomButtonWithAnimation))]
    public class CustomButtonWithAnimationEditor : ButtonEditor
    {
        private SerializedProperty _enter;
        private SerializedProperty _click;

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            serializedObject.Update();
            EditorGUILayout.PropertyField(_enter);
            EditorGUILayout.PropertyField(_click);
            serializedObject.ApplyModifiedProperties();
        }

        protected override void OnEnable()
        {
            base.OnEnable();
            _enter = serializedObject.FindProperty("_enter");
            _click = serializedObject.FindProperty("_click");
        }
    }
}
