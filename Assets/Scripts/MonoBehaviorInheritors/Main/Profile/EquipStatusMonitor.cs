using MonoBehaviorInheritors.Common;
using UnityEngine;

namespace MonoBehaviorInheritors.Main.Profile
{
    public class EquipStatusMonitor : MonoBehaviour
    {
        [SerializeField]private CustomButtonWithoutAnimation _equipButton;
        private void OnEnable()
        {
            _equipButton.IsElementOpen = true;
        }
        private void OnDisable()
        {
            _equipButton.IsElementOpen = false;
        }
    }
}