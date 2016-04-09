using UnityEngine;
using UnityEditor;

public class TestInputChange : MonoBehaviour
{
    private SerializedObject _serializedObject;
    void Start ()
    {
        _serializedObject = new SerializedObject(AssetDatabase.LoadAllAssetsAtPath("ProjectSettings/InputManager.asset")[0]);
        SerializedProperty axis = _serializedObject.FindProperty("m_Axes");
        while (true)
        {
            axis.Next(true);
            Debug.Log(axis.stringValue);
        }
    }

}
