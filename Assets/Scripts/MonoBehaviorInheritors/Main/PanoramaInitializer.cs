using UnityEngine;

namespace MonoBehaviorInheritors.Main
{
    public class PanoramaInitializer : MonoBehaviour
    {
        public void Initialize()
        {
            Vector3 defaultCameraPosition = new Vector3(-9.6f, 0f, -99f);
            PanoramaScrollController panoramaScrollController = GetComponentInChildren<PanoramaScrollController>();
            Transform cameraTransform = transform.Find("PanoramaCamera");
            Transform firstSprite = transform.Find("FirstSprite");
            Transform secondSprite = transform.Find("SecondSprite");
            panoramaScrollController.StaticSprite = firstSprite;
            panoramaScrollController.DynamicSprite = secondSprite;
            cameraTransform.position = defaultCameraPosition;
        }
    }
}