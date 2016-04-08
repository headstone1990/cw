using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace MonoBehaviorInh.Common
{
    [RequireComponent(typeof(AudioSource))]
    [RequireComponent(typeof(Animator))]
    public class CustomButtonContloller : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler, ISelectHandler, IDeselectHandler, IUpdateSelectedHandler {
        private Animator _animator;
        private AudioSource _audioSource;
        private bool _isPointerDown;
        [SerializeField]
        private UnityEvent _onPointerClick = null; // Set in inspector
        [SerializeField]
        private AudioClip _enter = null; // Set in inspector
        [SerializeField]
        private AudioClip _down = null; // Set in inspector


        private void Awake()
        {
            _animator = GetComponent<Animator>();
            _audioSource = GetComponent<AudioSource>();
        }

        public void OnPointerEnter(PointerEventData eventData)
        {
            _animator.SetBool("IsMouseEnter", true);
            if (_isPointerDown == false)
            {
                _audioSource.PlayOneShot(_enter);
            }

        }
        public void OnPointerExit(PointerEventData eventData)
        {
            _animator.SetBool("IsMouseEnter", false);

        }
        public void OnPointerDown(PointerEventData eventData)
        {
            _animator.SetBool("isMouseDown", true);
            _isPointerDown = true;
            _audioSource.PlayOneShot(_down);
        }
        public void OnPointerUp(PointerEventData eventData)
        {
            _animator.SetBool("isMouseDown", false);
            _isPointerDown = false;
            _onPointerClick.Invoke();
        }

        public void OnSelect(BaseEventData eventData)
        {
            _animator.SetBool("IsMouseEnter", true);
            if (_isPointerDown == false)
            {
                _audioSource.PlayOneShot(_enter);
            }
        }

        public void OnDeselect(BaseEventData eventData)
        {
            _animator.SetBool("IsMouseEnter", false);
        }

        public void OnUpdateSelected(BaseEventData eventData)
        {
            if (Input.GetButtonDown("Submit"))
            {
                _animator.SetBool("isMouseDown", true);
                _isPointerDown = true;
                _audioSource.PlayOneShot(_down);
            }
            if (Input.GetButtonUp("Submit"))
            {
                _animator.SetBool("isMouseDown", false);
                _isPointerDown = false;
                _onPointerClick.Invoke();
            }
        }
    }
}
