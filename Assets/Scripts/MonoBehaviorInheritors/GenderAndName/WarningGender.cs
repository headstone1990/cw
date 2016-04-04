using UnityEngine;
using System.Collections;

public class WarningGender : MonoBehaviour
{
    public GameObject warning;
    public GameObject genderSelect;
    public GameObject nameSelect;

    public void OnClick()
    {
        if (GlobalVariables.gender == null)
        {
            warning.SetActive(true);
        }
        else
        {
            genderSelect.SetActive(false);
            nameSelect.SetActive(true);
        }
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            warning.SetActive(false);
        }
    }
}