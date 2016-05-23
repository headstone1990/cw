using UnityEngine;

namespace MonoBehaviorInheritors.Main.Profile
{
    public class ElementsSwitcher : MonoBehaviour
    {
        [SerializeField] private GameObject[] _mainElements;
        [SerializeField] private GameObject[] _switchedElements;
        public void Switch()
        {
            foreach (GameObject mainElement in _mainElements)
            {
                mainElement.SetActive(!mainElement.activeSelf);
            }
            if (_mainElements[0].activeSelf)
            {
                foreach (GameObject switchedElement in _switchedElements)
                {
                    switchedElement.SetActive(false);
                }
            }
            else
            {
                foreach (GameObject switchedElement in _switchedElements)
                {
                    switchedElement.SetActive(true);
                }
            }
        }
    }
}