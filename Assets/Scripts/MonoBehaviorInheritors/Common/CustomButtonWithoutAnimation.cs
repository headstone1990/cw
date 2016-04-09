using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace MonoBehaviorInheritors.Common
{
    public class CustomButtonWithoutAnimation : Button
    {
        private EventSystem _eventSystem;

        protected override void Awake()
        {
            base.Awake();
            _eventSystem = GameObject.FindGameObjectWithTag("EventSystem").GetComponent<EventSystem>();
        }

        public override void OnPointerEnter(PointerEventData eventData)
        {
            base.OnPointerEnter(eventData);
            Select();
        }

        public override void OnPointerExit(PointerEventData eventData)
        {
            base.OnPointerExit(eventData);
            _eventSystem.SetSelectedGameObject(null);
        }

        public override void OnSelect(BaseEventData eventData)
        {
            base.OnSelect(eventData);
            DoStateTransition(SelectionState.Highlighted, false);
        }

        public override void OnDeselect(BaseEventData eventData)
        {
            base.OnDeselect(eventData);
            DoStateTransition(SelectionState.Normal, false);
        }

        public override void OnSubmit(BaseEventData eventData)
        {
            if (!IsActive() || !IsInteractable())
                return;
            DoStateTransition(SelectionState.Pressed, false);
            StartCoroutine(OnFinishSubmit());
        }

        private IEnumerator OnFinishSubmit()
        {
            while (Input.GetButton("Submit"))
            {
                yield return null;
            }
            DoStateTransition(SelectionState.Normal, false);
            onClick.Invoke();
        }
    }
}
