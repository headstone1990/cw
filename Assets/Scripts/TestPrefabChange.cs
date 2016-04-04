using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TestPrefabChange : MonoBehaviour
{
    public GameObject TestPrefab;
    public GameObject TestGameObject;

    public void PrefabChange()
    {
        TestGameObject.GetComponent<Image>().color = Color.black;
        Debug.Log(TestPrefab.GetType());
        Debug.Log(TestGameObject.GetType());
    }
}
