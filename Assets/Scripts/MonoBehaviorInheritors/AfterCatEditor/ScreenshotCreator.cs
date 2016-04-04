using System;
using System.Collections;
using System.IO;
using JetBrains.Annotations;
using UnityEngine;

namespace MonoBehaviorInheritors.AfterCatEditor
{
    public class ScreenshotCreator : MonoBehaviour
    {
        [SerializeField] private GameObject[] _switchableUiElements = null; //Set in inspedctor

        [UsedImplicitly]
        public void OnClickScreenCaptureButton()
        {
            StartCoroutine(CaptureScreen());
        }

        private IEnumerator CaptureScreen()
        {
            yield return null;
            foreach (var uiElement in _switchableUiElements)
            {
                uiElement.SetActive(false);
            }
            yield return new WaitForEndOfFrame();
            if (!Directory.Exists(Application.dataPath + "/Screenshots"))
            {
                Directory.CreateDirectory(Application.dataPath + "/Screenshots");
            }
            var filePath = string.Format("{0}/Screenshots/{1}-{2}-{3} {4}.{5}.{6}.png", Application.dataPath,
                DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute,
                DateTime.Now.Second);
            Application.CaptureScreenshot(filePath);
            foreach (var element in _switchableUiElements)
            {
                element.SetActive(true);
            }
        }
        //[Show]
        //private void HideElements()
        //{
        //    foreach (var uiElement in SwitchableUiElements)
        //    {
        //        uiElement.SetActive(false);
        //    }
        //}
    }
}