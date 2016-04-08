using UnityEngine;
using UnityEngine.EventSystems;


namespace MonoBehaviorInh.Common
{
    public class GameObjectSelector : MonoBehaviour
    {
        [SerializeField] private EventSystem _eventSystem;
        [SerializeField] private GameObject _defaultGameObject;

        private void Update()
        {
            if (_eventSystem.currentSelectedGameObject == null)
            {
                if (Input.GetButtonDown("Horizontal") || Input.GetButtonDown("Vertical"))
                {
                    _eventSystem.SetSelectedGameObject(_defaultGameObject);
                }

            }
        }
    }
}