using MonoBehaviorInheritors.Common;
using UnityEngine;

namespace MonoBehaviorInheritors.Main.Profile
{
    public class ElementStatusMonitor : MonoBehaviour
    {
        [SerializeField]private CustomButtonWithoutAnimation _elementButton;
        private void OnEnable()
        {
            _elementButton.IsElementOpen = true;
        }
        private void OnDisable()
        {
            _elementButton.IsElementOpen = false;
        }
    }
}