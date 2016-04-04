using UnityEngine;
using UnityEngine.UI;

namespace MonoBehaviorInh.Common
{
    public class FakeScrollBar : MonoBehaviour {
        [SerializeField]
        private ScrollRect _scrollRect;

        public void PassThrough(float scrollValue)
        {
            _scrollRect.verticalNormalizedPosition = scrollValue;
        }
    }
}
