using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonAlpha : MonoBehaviour
{
    private Image _image;
    public float AlphaThreshold = 0.01f;
    public string Location;


    void Start()
    {
        _image = GetComponent<Image>();
        _image.eventAlphaThreshold = AlphaThreshold;
    }


    public void Goto()
    {
        SceneManager.LoadScene(Location);
    }
}
