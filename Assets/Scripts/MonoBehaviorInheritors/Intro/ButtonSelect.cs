using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ButtonSelect : MonoBehaviour
{
    Button button;
    void Awake()
    {
        button = GetComponent<Button>();
    }
    public void OnPointer()
    {
        button.Select();
    }
}
