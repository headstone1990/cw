using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace MonoBehaviorInheritors.Common
{
    public class AnotherCustomButtonWithoutAnimation : Button
    {
        public bool isElementOpen { get; set; }

        private void Update()
        {
            if (isElementOpen)
            {
                DoStateTransition(SelectionState.Pressed, false);
            }
        }
    }
}