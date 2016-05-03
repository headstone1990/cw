using UnityEngine;
using UnityEditor;
using System.Collections;

[CustomEditor(typeof(TraitSelect))]
[CanEditMultipleObjects]
public class TraitSelectEditor : Editor
{

    private SerializedProperty _trait;
    private SerializedProperty _description;


    void OnEnable()
    {
        _trait = serializedObject.FindProperty("Trait");
        _description = serializedObject.FindProperty("Description");
    }

    public override void OnInspectorGUI()
    {
        serializedObject.Update();
        EditorGUILayout.LabelField("Trait:");
        _trait.stringValue = EditorGUILayout.TextField(_trait.stringValue);
        EditorGUILayout.LabelField("Description:");
        _description.stringValue = EditorGUILayout.TextArea(_description.stringValue, GUILayout.Height(100f));
        serializedObject.ApplyModifiedProperties();
        //TraitSelect myTarget = (TraitSelect) target;
        //EditorGUILayout.LabelField("Trait:");
        //myTarget.Trait = EditorGUILayout.TextField(myTarget.Trait);
        //EditorGUILayout.LabelField("Description:");
        //myTarget.Description = EditorGUILayout.TextArea(myTarget.Description, GUILayout.Height(100f));
    }

}
