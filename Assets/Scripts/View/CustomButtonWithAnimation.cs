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
        private AudioClip highlightSound; // Set in inspector

        [SerializeField]
        private AudioClip clickSound; // Set in inspector

        private new Animator animator;

        private AudioSource audioSource;

        private bool mouseOverButton;

        protected override void Awake()
        {
            base.Awake();
            animator = GetComponent<Animator>();
            audioSource = GetComponent<AudioSource>();
        }

        public override void OnPointerEnter(PointerEventData eventData)
        {
            base.OnPointerEnter(eventData);
            animator.SetBool("IsPointerEnter", true);
            if (mouseOverButton) return;

            audioSource.PlayOneShot(highlightSound);
            mouseOverButton = true;
        }

        public override void OnPointerExit(PointerEventData eventData)
        {
            base.OnPointerExit(eventData);
            animator.SetBool("IsPointerEnter", false);
            mouseOverButton = false;
        }

        public override void OnPointerDown(PointerEventData eventData)
        {
            base.OnPointerDown(eventData);
            animator.SetBool("IsPointerClick", true);
            audioSource.PlayOneShot(clickSound);
        }

        public override void OnPointerUp(PointerEventData eventData)
        {
            base.OnPointerUp(eventData);
            animator.SetBool("IsPointerClick", false);
        }

        public override void OnSelect(BaseEventData eventData)
        {
            base.OnSelect(eventData);
            if (mouseOverButton) return;
            animator.SetBool("IsPointerEnter", true);
            audioSource.PlayOneShot(highlightSound);
        }

        public override void OnDeselect(BaseEventData eventData)
        {
            base.OnDeselect(eventData);
            if (mouseOverButton) return;
            animator.SetBool("IsPointerEnter", false);
        }

        public override void OnSubmit(BaseEventData eventData)
        {
            if (!IsActive() || !IsInteractable()) return;

            DoStateTransition(SelectionState.Pressed, false);
            animator.SetBool("IsPointerClick", true);
            audioSource.PlayOneShot(clickSound);
            StartCoroutine(OnFinishSubmit());
        }

        private IEnumerator OnFinishSubmit()
        {
            while (Input.GetButton("Submit")) yield return null;

            DoStateTransition(SelectionState.Highlighted, false);
            animator.SetBool("IsPointerClick", false);
            onClick.Invoke();
        }
    }
}