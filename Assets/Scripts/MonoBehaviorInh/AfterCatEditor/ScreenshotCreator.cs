using System;
using System.IO;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace MonoBehaviorInh.AfterCatEditor
{
    public class ScreenshotCreator : MonoBehaviour
    {
        [SerializeField] private Text text;
        [SerializeField] private GameObject[] _switchableUIElemnts = null; //Set in inspedctor

        public void OnClickScreenCaptureButton()
        {
            StartCoroutine(CaptureScreen());
        }

        private IEnumerator CaptureScreen()
        {
            yield return null;
            foreach (var switchableUIElement in _switchableUIElemnts)
            {
                switchableUIElement.SetActive(false);
            }
            yield return new WaitForEndOfFrame();
            //Debug.Log(Application.persistentDataPath + "/Screenshots/" + DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString() + " " + DateTime.Now.Hour.ToString() + "");
            Directory.CreateDirectory(Application.dataPath + "/Screenshots");
            var filePath = string.Format("{0}/Screenshots/{1}-{2}-{3} {4}.{5}.{6}.png", Application.dataPath, DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
            //text.text = filePath;
            Application.CaptureScreenshot(filePath);
            foreach (var element in _switchableUIElemnts)
            {
                element.SetActive(true);
            }
        }
    }
}