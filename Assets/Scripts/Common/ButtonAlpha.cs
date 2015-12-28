using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonAlpha : MonoBehaviour
{


    public Image im1;
    public float eventAlphaThreshold = 0.01f;
    public string location;

    void Start()
    {
        im1.eventAlphaThreshold = eventAlphaThreshold;
    }

    public void Goto()
    {
        SceneManager.LoadScene(location);
    }

}
