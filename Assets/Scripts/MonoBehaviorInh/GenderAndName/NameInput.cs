using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class NameInput : MonoBehaviour
{
    public GameObject warning;

    public void Name(string playerName)
    {
        GlobalVariables.playerName = playerName;
    }
    public void Done()
    {
        if (GlobalVariables.playerName == "" || GlobalVariables.playerName == null)
        {
            warning.SetActive(true);
        }
        else
        {
            SceneManager.LoadScene("Klubok");
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