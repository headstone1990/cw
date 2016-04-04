using UnityEngine;
using UnityEngine.UI;

namespace MonoBehaviorInh.Common
{
    public class ScrollValueChangerForFakeScrollBar : MonoBehaviour
    {
        [SerializeField]
        private Slider _slider;
        private ScrollRect _scrollRect;


        private void Awake()
        {
            _scrollRect = GetComponent<ScrollRect>();
        }

        public void PassThrough()
        {
            _slider.value = _scrollRect.verticalNormalizedPosition;
        }
    }
}
