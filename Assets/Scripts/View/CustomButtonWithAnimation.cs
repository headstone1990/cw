namespace CW.View
{
    using System.Collections;

    using UnityEngine;
    using UnityEngine.EventSystems;
    using UnityEngine.UI;

    [RequireComponent(typeof(AudioSource))]
    [RequireComponent(typeof(Animator))]
    public class CustomButtonWithAnimation : Button
    {
        [SerializeField]
        private AudioClip enter; // Set in inspector

        [SerializeField]
        private AudioClip click; // Set in inspector

        private new Animator animator;

        private AudioSource audioSource;

        private EventSystem eventSystem;

        public override void OnPointerEnter(PointerEventData eventData)
        {
            base.OnPointerEnter(eventData);
            GetComponent<Button>().Select();
        }

        public override void OnPointerExit(PointerEventData eventData)
        {
            base.OnPointerExit(eventData);
            eventSystem.SetSelectedGameObject(null);
        }

        public override void OnSubmit(BaseEventData eventData)
        {
            if (!IsActive() || !IsInteractable()) return;

            DoStateTransition(SelectionState.Pressed, false);
            animator.SetBool("IsPointerClick", true);
            audioSource.PlayOneShot(click);
            StartCoroutine(OnFinishSubmit());
        }

        public override void OnPointerDown(PointerEventData eventData)
        {
            base.OnPointerDown(eventData);
            animator.SetBool("IsPointerClick", true);
            audioSource.PlayOneShot(click);
        }

        public override void OnPointerUp(PointerEventData eventData)
        {
            base.OnPointerUp(eventData);
            animator.SetBool("IsPointerClick", false);
        }

        public override void OnSelect(BaseEventData eventData)
        {
            base.OnSelect(eventData);
            animator.SetBool("IsPointerEnter", true);
            audioSource.PlayOneShot(enter);
        }

        public override void OnDeselect(BaseEventData eventData)
        {
            base.OnDeselect(eventData);
            animator.SetBool("IsPointerEnter", false);
        }

        protected override void Awake()
        {
            base.Awake();
            animator = GetComponent<Animator>();
            audioSource = GetComponent<AudioSource>();
            eventSystem = EventSystem.current;
        }

        private IEnumerator OnFinishSubmit()
        {
            while (Input.GetButton("Submit")) yield return null;

            DoStateTransition(SelectionState.Normal, false);
            animator.SetBool("IsPointerClick", false);
            onClick.Invoke();
        }
    }
}