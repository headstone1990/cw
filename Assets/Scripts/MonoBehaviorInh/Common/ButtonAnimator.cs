using UnityEngine;
using UnityEngine.EventSystems;

namespace MonoBehaviorInh.Common
{
    [RequireComponent(typeof(AudioSource))]
    [RequireComponent(typeof(Animator))]
    public class ButtonAnimator : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler {
        private Animator _animator;
        private AudioSource _audioSource;
        private bool _isMouseDown;
        [SerializeField]
        private AudioClip _enter;
        [SerializeField]
        private AudioClip _down;


        private void Awake()
        {
            _animator = GetComponent<Animator>();
            _audioSource = GetComponent<AudioSource>();
        }

        public void OnPointerEnter(PointerEventData eventData)
        {
            _animator.SetBool("IsMouseEnter", true);
            if (_isMouseDown == false)
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
            _isMouseDown = true;
            _audioSource.PlayOneShot(_down);
        }
        public void OnPointerUp(PointerEventData eventData)
        {
            _animator.SetBool("isMouseDown", false);
            _isMouseDown = false;
        }
    }
}
