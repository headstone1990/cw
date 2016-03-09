using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class TestScreenshot : MonoBehaviour
{
    [SerializeField]
    private GameObject _hide;

    public void Capture()
    {
        StartCoroutine("Test");
    }
    private IEnumerator Test()
    {
        yield return null;
        _hide.SetActive(false);
        yield return new WaitForEndOfFrame();
        Application.CaptureScreenshot("screen.png");
        _hide.SetActive(true);
    }


}
