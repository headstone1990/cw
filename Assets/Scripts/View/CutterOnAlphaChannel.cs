namespace CW.View
{
    using UnityEngine;
    using UnityEngine.UI;

    public class CutterOnAlphaChannel : MonoBehaviour
    {
        private const float AlphaThreshold = 0.01f;
        private Image image;
     
        private void Awake()
        {
            image = GetComponent<Image>();
            image.alphaHitTestMinimumThreshold = AlphaThreshold;
        }
    }
}
