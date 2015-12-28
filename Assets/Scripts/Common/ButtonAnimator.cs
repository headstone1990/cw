using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ButtonAnimator : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler {
    Animator animator;
    AudioSource audioSource;
    public AudioClip enter;
    public AudioClip down;
    bool mouseDownded = false;

    void Awake()
    {
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        animator.SetBool("mouseEnter", true);
        if (mouseDownded == false)
        {
            audioSource.PlayOneShot(enter);
        }
        
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        animator.SetBool("mouseEnter", false);
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        animator.SetBool("mouseDown", true);
        mouseDownded = true;
        audioSource.PlayOneShot(down);
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        animator.SetBool("mouseDown", false);
        mouseDownded = false;
    }

}
