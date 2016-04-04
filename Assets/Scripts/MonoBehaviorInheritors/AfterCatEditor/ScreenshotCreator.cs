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
            if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/CW"))
            {
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/CW");
            }
            var filePath = string.Format("{0}/{1}.png", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/CW", DateTime.Now.ToString("yyyy_MM_dd_hh-mm-ss"));
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