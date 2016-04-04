using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GenderSelect : MonoBehaviour {
    public Toggle mToggle;
    public Toggle fToggle;

    public void SelectGender()
    {
        if (mToggle.isOn == true)
        {
            GlobalVariables.gender = "male";
        }
        else if (fToggle.isOn == true)
        {
            GlobalVariables.gender = "female";
        }
    }
}
