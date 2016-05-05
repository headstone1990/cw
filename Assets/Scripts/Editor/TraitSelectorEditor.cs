using UnityEngine;
using UnityEditor;
using System.Collections;

[CustomEditor(typeof(TraitSelector))]
[CanEditMultipleObjects]
public class TraitSelectorEditor : Editor
{

    private SerializedProperty _selectedTraitLocalizedString;
    private SerializedProperty _description;


    void OnEnable()
    {
        _selectedTraitLocalizedString = serializedObject.FindProperty("_selectedTraitLocalizedString");
        _description = serializedObject.FindProperty("_description");
    }

    public override void OnInspectorGUI()
    {
        serializedObject.Update();
        EditorGUILayout.LabelField("Trait:");
        _selectedTraitLocalizedString.stringValue = EditorGUILayout.TextField(_selectedTraitLocalizedString.stringValue);
        EditorGUILayout.LabelField("Description:");
        _description.stringValue = EditorGUILayout.TextArea(_description.stringValue, GUILayout.Height(100f));
        serializedObject.ApplyModifiedProperties();
        //TraitSelector myTarget = (TraitSelector) target;
        //EditorGUILayout.LabelField("Trait:");
        //myTarget.Trait = EditorGUILayout.TextField(myTarget.Trait);
        //EditorGUILayout.LabelField("Description:");
        //myTarget.Description = EditorGUILayout.TextArea(myTarget.Description, GUILayout.Height(100f));
    }

}
