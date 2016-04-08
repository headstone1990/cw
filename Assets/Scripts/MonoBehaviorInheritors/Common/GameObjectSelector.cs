using UnityEngine;
using UnityEngine.EventSystems;


namespace MonoBehaviorInh.Common
{
    public class GameObjectSelector : MonoBehaviour
    {
        [SerializeField] EventSystem _eventSystem;

        private void Update()
        {
            if (_eventSystem.currentSelectedGameObject == null)
            {
                if (Input.GetButtonDown("Horizontal") || Input.GetButtonDown("Vertical"))
                {
                    _eventSystem.SetSelectedGameObject(_eventSystem.firstSelectedGameObject);
                }

            }
        }
    }
}