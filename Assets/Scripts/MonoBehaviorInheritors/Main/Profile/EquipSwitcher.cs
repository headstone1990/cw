using UnityEngine;

namespace MonoBehaviorInheritors.Main.Profile
{
    public class EquipSwitcher : MonoBehaviour
    {
        [SerializeField] private GameObject[] _switchedElements;
        public void Switch()
        {
            foreach (GameObject switchedElement in _switchedElements)
            {
                switchedElement.SetActive(!switchedElement.activeSelf);
            }
        }
    }
}