namespace CW.View.Editor
{
    using UnityEditor;
    using UnityEditor.UI;

    [CanEditMultipleObjects]
    [CustomEditor(typeof(CustomButtonWithAnimation))]
    public class CustomButtonWithAnimationEditor : ButtonEditor
    {
        private SerializedProperty enter;
        private SerializedProperty click;

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            serializedObject.Update();
            EditorGUILayout.PropertyField(enter);
            EditorGUILayout.PropertyField(click);
            serializedObject.ApplyModifiedProperties();
        }

        protected override void OnEnable()
        {
            base.OnEnable();
            enter = serializedObject.FindProperty("enter");
            click = serializedObject.FindProperty("click");
        }
    }
}
