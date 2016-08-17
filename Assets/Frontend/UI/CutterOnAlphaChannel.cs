namespace CW.Frontend.UI
{
    using UnityEngine;
    using UnityEngine.UI;

    public class CutterOnAlphaChannel : MonoBehaviour
    {
        private const float AlphaThreshold = 0.01f;
        private Image _image;

        private void Awake()
        {
            _image = GetComponent<Image>();
            _image.alphaHitTestMinimumThreshold = AlphaThreshold;
        }
    }
}
