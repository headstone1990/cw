using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System.Collections;

namespace MonoBehaviorInheritors.Common
{
    [RequireComponent(typeof(AudioSource))]
    [RequireComponent(typeof(Animator))]
    public class CustomButtonWithAnimation : Button
    {
        [SerializeField]
        private AudioClip _enter = null; //Set in inspector
        [SerializeField]
        private AudioClip _click = null; //Set in inspector

        private Animator _animator;
        private AudioSource _audioSource;
        private EventSystem _eventSystem;


        protected override void Awake()
        {
            base.Awake();
            _animator = GetComponent<Animator>();
            _audioSource = GetComponent<AudioSource>();
            _eventSystem = GameObject.FindGameObjectWithTag("EventSystem").GetComponent<EventSystem>();
        }

        public override void OnPointerEnter(PointerEventData eventData)
        {
            base.OnPointerEnter(eventData);
            GetComponent<Button>().Select();
        }

        public override void OnPointerExit(PointerEventData eventData)
        {
            base.OnPointerExit(eventData);
            _eventSystem.SetSelectedGameObject(null);
        }

        public override void OnSubmit(BaseEventData eventData)
        {
            if (!IsActive() || !IsInteractable())
                return;
            DoStateTransition(SelectionState.Pressed, false);
            _animator.SetBool("IsPointerClick", true);
            _audioSource.PlayOneShot(_click);
            StartCoroutine(OnFinishSubmit());
        }

        public override void OnPointerDown(PointerEventData eventData)
        {
            base.OnPointerDown(eventData);
            _animator.SetBool("IsPointerClick", true);
            _audioSource.PlayOneShot(_click);
        }

        public override void OnPointerUp(PointerEventData eventData)
        {
            base.OnPointerUp(eventData);
            _animator.SetBool("IsPointerClick", false);
        }

        public override void OnPointerClick(PointerEventData eventData)
        {
            _audioSource.PlayOneShot(_click);
            base.OnPointerClick(eventData);
        }

        public override void OnSelect(BaseEventData eventData)
        {
            base.OnSelect(eventData);
            _animator.SetBool("IsPointerEnter", true);
            _audioSource.PlayOneShot(_enter);
        }

        public override void OnDeselect(BaseEventData eventData)
        {
            base.OnDeselect(eventData);
            _animator.SetBool("IsPointerEnter", false);
        }


        private IEnumerator OnFinishSubmit()
        {
            while (Input.GetButton("Submit"))
            {
                yield return null;
            }
            DoStateTransition(SelectionState.Normal, false);
            _animator.SetBool("IsPointerClick", false);
            onClick.Invoke();
        }

    }
}