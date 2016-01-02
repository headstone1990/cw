using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SelectText : MonoBehaviour
{
    Text text;
    public string textStringM;
    public string textStringF;

    void Awake()
    {
        text = GetComponent<Text>();
    }

    void Start()
    {
        if (GlobalVariables.gender == "male")
        {
            text.text = textStringM;
        }
        else if (GlobalVariables.gender == "female")
        {
            text.text = textStringF;
        }
    }
}