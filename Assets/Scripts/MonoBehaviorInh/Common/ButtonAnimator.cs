using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonAnimator : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler {
    private Animator _animator;
    private AudioSource _audioSource;
    private bool _mouseDownded;


    public AudioClip Enter;
    public AudioClip Down;


    void Awake()
    {
        _animator = GetComponent<Animator>();
        _audioSource = GetComponent<AudioSource>();
    }


    public void OnPointerEnter(PointerEventData eventData)
    {
        _animator.SetBool("mouseEnter", true);
        if (_mouseDownded == false)
        {
            _audioSource.PlayOneShot(Enter);
        }
        
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        _animator.SetBool("mouseEnter", false);
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        _animator.SetBool("mouseDown", true);
        _mouseDownded = true;
        _audioSource.PlayOneShot(Down);
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        _animator.SetBool("mouseDown", false);
        _mouseDownded = false;
    }

}
