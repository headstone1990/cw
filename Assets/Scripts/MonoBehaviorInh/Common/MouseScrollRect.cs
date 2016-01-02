using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MouseScrollRect : MonoBehaviour
{
    ScrollRect rect;

    void Awake()
    {
        rect = GetComponent<ScrollRect>();
    }
    void Update()
    {
        if (GlobalVariables.mouseOnScrollBar)
        {
            rect.enabled = true;
        }
        else
        {
            if (Input.GetKey(KeyCode.Mouse0))
            {
                rect.enabled = false;
            }
            else
            {
                rect.enabled = true;
            }
        }
        
    }
}
