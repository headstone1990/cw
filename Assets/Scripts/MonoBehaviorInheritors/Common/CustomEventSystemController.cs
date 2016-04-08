using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


namespace MonoBehaviorInh.Common
{
    public class CustomEventSystemController : MonoBehaviour
    {
        private EventSystem _eventSystem;
        [SerializeField] private GameObject _defaultGameObject;
        private GameObject _previosSelectedGameObject;

        private void Awake()
        {
            _eventSystem = GetComponent<EventSystem>();
            _previosSelectedGameObject = _defaultGameObject;
        }

        private void Update()
        {
            if (_eventSystem.currentSelectedGameObject == null)
            {
                if (Input.GetAxis("Horizontal") < 0f)
                {
                   _eventSystem.SetSelectedGameObject(_previosSelectedGameObject.GetComponent<Button>().FindSelectableOnLeft() != null ? _previosSelectedGameObject.GetComponent<Button>().FindSelectableOnLeft().gameObject : _previosSelectedGameObject);
                }
                else if (Input.GetAxis("Horizontal") > 0f)
                {
                    _eventSystem.SetSelectedGameObject(_previosSelectedGameObject.GetComponent<Button>().FindSelectableOnRight() != null ? _previosSelectedGameObject.GetComponent<Button>().FindSelectableOnRight().gameObject : _previosSelectedGameObject);
                }
                else if (Input.GetAxis("Vertical") < 0f)
                {
                    _eventSystem.SetSelectedGameObject(_previosSelectedGameObject.GetComponent<Button>().FindSelectableOnDown() != null ? _previosSelectedGameObject.GetComponent<Button>().FindSelectableOnDown().gameObject : _previosSelectedGameObject);
                }
                else if (Input.GetAxis("Vertical") > 0f)
                {
                    _eventSystem.SetSelectedGameObject(_previosSelectedGameObject.GetComponent<Button>().FindSelectableOnUp() != null ? _previosSelectedGameObject.GetComponent<Button>().FindSelectableOnUp().gameObject : _previosSelectedGameObject);
                }
            }
            if (Input.GetButtonUp("Cancel"))
            {
                _eventSystem.SetSelectedGameObject(null);
            }

            if (_eventSystem.currentSelectedGameObject !=  null)
            {
                _previosSelectedGameObject = _eventSystem.currentSelectedGameObject;
            }
        }
    }
}