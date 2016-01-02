using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PresetsOrEditor : MonoBehaviour {

    public void Presets()
    {
        GlobalVariables.presetsOrEditor = "Presets";
    }
    public void Editor()
    {
        GlobalVariables.presetsOrEditor = "Editor";
    }
    public void Back()
    {
        if (GlobalVariables.presetsOrEditor == "Presets")
        {
            SceneManager.LoadScene("Prestes");
        }
        else if (GlobalVariables.presetsOrEditor == "Editor")
        {
            SceneManager.LoadScene("Editor");
        }
    }
}
