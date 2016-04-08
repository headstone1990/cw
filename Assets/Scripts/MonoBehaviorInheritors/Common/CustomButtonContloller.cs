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
        [SerializeField]
        private UnityEvent _onPointerClick = null; // Set in inspector
        [SerializeField]
        private AudioClip _enter = null; // Set in inspector
        [SerializeField]
        private AudioClip _down = null; // Set in inspector

        private bool _isMouseEnterPrevios;
        private bool _isMouseDownPrevios;


        private void Awake()
        {
            _animator = GetComponent<Animator>();
            _audioSource = GetComponent<AudioSource>();
        }

        public void OnPointerEnter(PointerEventData eventData)
        {
            _animator.SetBool("IsMouseEnter", true);

        }
        public void OnPointerExit(PointerEventData eventData)
        {
            _animator.SetBool("IsMouseEnter", false);

        }
        public void OnPointerDown(PointerEventData eventData)
        {
            _animator.SetBool("IsMouseDown", true);
        }
        public void OnPointerUp(PointerEventData eventData)
        {
            _animator.SetBool("IsMouseDown", false);
            _onPointerClick.Invoke();
        }

        public void OnSelect(BaseEventData eventData)
        {
            _animator.SetBool("IsMouseEnter", true);
        }

        public void OnDeselect(BaseEventData eventData)
        {
            _animator.SetBool("IsMouseEnter", false);
        }

        public void OnUpdateSelected(BaseEventData eventData)
        {
            if (Input.GetButtonDown("Submit"))
            {
                _animator.SetBool("IsMouseDown", true);
            }
            if (Input.GetButtonUp("Submit"))
            {
                _animator.SetBool("IsMouseDown", false);
                _onPointerClick.Invoke();
            }
        }

        private void Update()
        {
            if (_animator.GetBool("IsMouseEnter") != _isMouseEnterPrevios)
            {
                if (_animator.GetBool("IsMouseEnter") == true)
                {
                    _audioSource.PlayOneShot(_enter);
                }
            }
            if (_animator.GetBool("IsMouseDown") != _isMouseDownPrevios)
            {
                if (_animator.GetBool("IsMouseDown") == true)
                {
                    _audioSource.PlayOneShot(_down);
                }
            }
            _isMouseEnterPrevios = _animator.GetBool("IsMouseEnter");
            _isMouseDownPrevios = _animator.GetBool("IsMouseDown");
        }
    }
}
