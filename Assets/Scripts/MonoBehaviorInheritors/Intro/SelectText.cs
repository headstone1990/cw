using System;

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SelectText : MonoBehaviour
{
    Text text;
    public string textStringM;
    public string textStringF;

    private void Awake()
    {
        this.text = this.GetComponent<Text>();
    }

    private void Start()
    {
        throw new NotImplementedException();

//        if (GlobalVariables.gender == "male")
//        {
//            text.text = textStringM;
//        }
//        else if (GlobalVariables.gender == "female")
//        {
//            text.text = textStringF;
//        }
    }
}