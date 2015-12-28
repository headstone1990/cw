using UnityEngine;
using System.Collections;

public class Next : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip down;
    public Animator animator;
    public GameObject[] g;
    int isOn = 1;
    int isOff = 0;


    public void OnClick()
    {
        if (isOn <= g.Length)
        {
            g[isOff].SetActive(false);
            g[isOn].SetActive(true);
            isOff++;
            isOn++;
        }
    }
    
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            animator.SetBool("mouseDown", true);
            audioSource.PlayOneShot(down);
        }
        if (Input.GetKeyUp("space"))
        {
            OnClick();
            animator.SetBool("mouseDown", false);
        }
    }

}