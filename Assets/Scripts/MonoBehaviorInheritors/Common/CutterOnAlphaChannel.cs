using UnityEngine;
using UnityEngine.UI;

namespace MonoBehaviorInh.Common
{
    public class CutterOnAlphaChannel : MonoBehaviour
    {
        private Image _image;
        private const float AlphaThreshold = 0.01f;


        private void Awake()
        {
            _image = GetComponent<Image>();
            _image.eventAlphaThreshold = AlphaThreshold;
        }
    }
}
