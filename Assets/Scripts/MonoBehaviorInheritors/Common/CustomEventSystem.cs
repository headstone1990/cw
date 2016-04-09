using Interfaces;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace MonoBehaviorInheritors.Common
{
    public class CustomEventSystem : EventSystem, IOnWarningSwitch
    {
        [SerializeField] private GameObject _defaultGameObject;
        private GameObject _previosSelectedGameObject;

        protected override void Awake()
        {
            base.Awake();
            _previosSelectedGameObject = _defaultGameObject;
        }

        protected override void Update()
        {
            base.Update();
            if (currentSelectedGameObject == null)
            {
                if (Input.GetAxis("Horizontal") < 0f)
                {
                    SetSelectedGameObject(_previosSelectedGameObject.GetComponent<Button>().FindSelectableOnLeft() !=
                                          null
                        ? _previosSelectedGameObject.GetComponent<Button>().FindSelectableOnLeft().gameObject
                        : _previosSelectedGameObject);
                }
                else if (Input.GetAxis("Horizontal") > 0f)
                {
                    SetSelectedGameObject(_previosSelectedGameObject.GetComponent<Button>().FindSelectableOnRight() !=
                                          null
                        ? _previosSelectedGameObject.GetComponent<Button>().FindSelectableOnRight().gameObject
                        : _previosSelectedGameObject);
                }
                else if (Input.GetAxis("Vertical") < 0f)
                {
                    SetSelectedGameObject(_previosSelectedGameObject.GetComponent<Button>().FindSelectableOnDown() !=
                                          null
                        ? _previosSelectedGameObject.GetComponent<Button>().FindSelectableOnDown().gameObject
                        : _previosSelectedGameObject);
                }
                else if (Input.GetAxis("Vertical") > 0f)
                {
                    SetSelectedGameObject(_previosSelectedGameObject.GetComponent<Button>().FindSelectableOnUp() != null
                        ? _previosSelectedGameObject.GetComponent<Button>().FindSelectableOnUp().gameObject
                        : _previosSelectedGameObject);
                }
            }

            if (Input.GetButtonUp("Cancel"))
            {
                SetSelectedGameObject(null);
            }

            if (currentSelectedGameObject != null)
            {
                _previosSelectedGameObject = currentSelectedGameObject;
            }
        }



        public void OnWarningEnable(GameObject warningButton, params Button[] disabledButtons)
        {
            SetSelectedGameObject(null);
            foreach (Button button in disabledButtons)
            {
                button.enabled = false;
            }
            SetSelectedGameObject(warningButton);
        }

        public void OnWarningDisable(params Button[] enabledButtons)
        {
            foreach (Button button in enabledButtons)
            {
                button.enabled = true;
            }
            SetSelectedGameObject(null);
        }
    }
}