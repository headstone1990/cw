namespace CW.Frontend.CustomUIElements
{
    using Interfaces;
    using UnityEngine;
    using UnityEngine.EventSystems;
    using UnityEngine.UI;

    public class CustomEventSystem : EventSystem, IOnWarningSwitch
    {
        [SerializeField] private GameObject _defaultGameObject = null; //Set in inspector //Элемент, который по умолчанию является "selected"
        private GameObject _previousSelectedGameObject;

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

        protected override void Awake()
        {
            base.Awake();
            _previousSelectedGameObject = _defaultGameObject;
        }

        protected override void Update()
        {
            base.Update();
            if (currentSelectedGameObject == null)
            {
                SelectSelectableWhenNothingIsSelected();
            }

            if (Input.GetButtonUp("Cancel"))
            {
                SetSelectedGameObject(null);
            }

            if (currentSelectedGameObject != null)
            {
                _previousSelectedGameObject = currentSelectedGameObject;
            }
        }

        // выбрать объект, когда никакой другой объект не выбран
        private void SelectSelectableWhenNothingIsSelected()
        {
            if (Input.GetAxis("Horizontal") < 0f)
            {
                SetSelectedGameObject(
                    _previousSelectedGameObject.GetComponent<Button>().FindSelectableOnLeft() != null
                        ? _previousSelectedGameObject.GetComponent<Button>().FindSelectableOnLeft().gameObject
                        : _previousSelectedGameObject);
            }
            else if (Input.GetAxis("Horizontal") > 0f)
            {
                SetSelectedGameObject(
                    _previousSelectedGameObject.GetComponent<Button>().FindSelectableOnRight() != null
                        ? _previousSelectedGameObject.GetComponent<Button>().FindSelectableOnRight().gameObject
                        : _previousSelectedGameObject);
            }
            else if (Input.GetAxis("Vertical") < 0f)
            {
                SetSelectedGameObject(
                    _previousSelectedGameObject.GetComponent<Button>().FindSelectableOnDown() != null
                        ? _previousSelectedGameObject.GetComponent<Button>().FindSelectableOnDown().gameObject
                        : _previousSelectedGameObject);
            }
            else if (Input.GetAxis("Vertical") > 0f)
            {
                SetSelectedGameObject(
                    _previousSelectedGameObject.GetComponent<Button>().FindSelectableOnUp() != null
                        ? _previousSelectedGameObject.GetComponent<Button>().FindSelectableOnUp().gameObject
                        : _previousSelectedGameObject);
            }
        }
    }
}