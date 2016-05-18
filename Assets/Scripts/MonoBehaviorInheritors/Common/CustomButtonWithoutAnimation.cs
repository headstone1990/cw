using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace MonoBehaviorInheritors.Common
{
    [RequireComponent(typeof(AudioSource))]
    public class CustomButtonWithoutAnimation : Button
    {
        private bool _isElementOpen;
        private AudioSource _audioSource;
        [SerializeField] private AudioClip _enter;
        [SerializeField] private AudioClip _click;
        public bool IsElementOpen
        {
            private get { return _isElementOpen; }
            set
            {
                _isElementOpen = value;
                if (IsElementOpen)
                {
                    StartCoroutine(OnElementOpened());
                }
            }
        }


        protected override void Awake()
        {
            base.Awake();
            _audioSource = GetComponent<AudioSource>();
            _audioSource.playOnAwake = false;
        }

        public override void OnPointerEnter(PointerEventData eventData)
        {
            _audioSource.PlayOneShot(_enter);
            if (IsElementOpen) return;
            base.OnPointerEnter(eventData);
            Select();
        }

        public override void OnPointerExit(PointerEventData eventData)
        {
            if (IsElementOpen) return;
            base.OnPointerExit(eventData);
            EventSystem.current.SetSelectedGameObject(null);
        }

        public override void OnSelect(BaseEventData eventData)
        {
            base.OnSelect(eventData);
            DoStateTransition(SelectionState.Highlighted, false);
        }

        public override void OnDeselect(BaseEventData eventData)
        {
            if (IsElementOpen) return;
            base.OnDeselect(eventData);
            DoStateTransition(SelectionState.Normal, false);
        }

        public override void OnPointerDown(PointerEventData eventData)
        {
            base.OnPointerDown(eventData);
            _audioSource.PlayOneShot(_click);
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

        private IEnumerator OnElementOpened()
        {
            while (IsElementOpen)
            {
                DoStateTransition(SelectionState.Pressed, false);
                yield return null;
            }
        }
    }
}
